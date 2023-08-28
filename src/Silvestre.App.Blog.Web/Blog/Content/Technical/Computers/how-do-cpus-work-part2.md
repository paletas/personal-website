---
title: "Understanding CPU Operation: A Programmer's Guide to program execution (Part 2)"
description: "Discover the inner workings of the CPU and how it brings programs to life."
summary: "An introduction to concepts related to program execution on the CPU, demystifying the process to programmers that don't know."
tags: 
  - processor
  - cpu
  - how does it work
  - computer architecture
draft: true
creationDate: 2023-08-28T20:57:00
updateDate: 
---

# Introduction

In [Part 1](how-do-cpus-work-part1) we took a look at key concepts of CPU components and architecture, we also took a look at the instruction cycle and how it works. So we now know how programs go from being written, compiled into instructions that the CPU can execute and how the execution cycle handles the execution of those instructions, but how do we actually make the computer do useful things? We all use a computer, we have monitors, keyboards and mouses, how do we go from keyboard presses to something showing up on the screen? How does a program store things on hard drive? How can we use memory beyond the embedded registers?

# Intructions and Data

In the previous post we talked about the instruction cycle, and how the CPU fetches instructions from memory, decodes them and executes them. But how does the CPU know what is an instruction and what is data? How does it know what to execute and what to store?

CPUs are a chip and as most chips do they have pins for power, ground and data input/output, the pin layout is different for each CPU, but they all have a set of pins that are used to communicate with the outside world, these pins are called the **bus**. The bus is a set of wires that are used to transfer data between the CPU and other components, the bus is divided into three parts:

- **Address Bus**: This is a set of wires that are used to specify a memory address, the CPU uses this to tell the memory what address it wants to read or write to.
- **Data Bus**: This is a set of wires that are used to transfer data between the CPU and other components, the CPU uses this to read or write data to memory or other components.
- **Control Bus**: This is a set of wires that are used to control the flow of data between the CPU and other components, the CPU uses this to tell the memory to read or write data, or to tell other components to do something.

## Bus Controller

Between the CPU and the other components, there will typically be something called a bus controller, it's main function is to decide, based on the address bus, where to send the memory access signals from the CPU. If the address is in the range of the memory, it will send the signals to the memory, if it is in the range of the hard drive, it will send the signals to the hard drive, and so on. Visualize the different bus as just a set of wires connecting from the CPU into the bus controller, and from there into the different components. 

![Bus Controller](img/blog/content/technical/computers/how-do-cpus-work/bus-controller.png "Bus Controller")

## Address Bus

This is used to tell the memory, or other components, what address it wants to read or write to. This is what the bus controller uses to decide what components are being targeted. Typically memory will be within the first ranges of memory so, if you use any address between 0x0000 and 0x7FFF, the bus controller will send the signals to the memory, and now other components can use different addresses, say 0x8000 to 0x8100 for the PCI devices (graphic cards, sound cards, etc), and so on. Some components might not care about the address, but it will still be used by the controller to decide what to do with the data.

## Data Bus

This carries the data that we're sending, or receiving, from the memory or other components. This is what the bus controller uses to send the data to the memory or other components. This is also what the CPU uses to read or write data to the memory or other components.

## Control Bus

This carries the control signals that are used to tell the memory or other components what to do, this can typically be a code that is to be understood by the other component. For example, the CPU can send a signal to the memory to read data, or to write data, or to reset the memory, or to tell the memory to wait for a signal from the CPU, and so on.

# Making Use of the Address Space: turning our programs useful

## Intruction set: Adding memory space access capabilities

Let's define two new instructions for our CPU, these will be responsible for writing and reading from memory.

``` assembly
// Write to memory addr R0, the data R1 and the control bits R2 (only the first 4 bits are used from R2)
WRITE R0, R1, R2

// Read from memory addr R0, store the data in R1 and the control bits R2 (only the first 4 bits are used from R2)
READ R0, R1, R2
``` 
We're also defining that we're using the full amount of memory possible (8KB) on the address space 0x0000 to 0x1FFFF and we have a keyboard available at 0x20000.

## Using the New Instructions

With the new instructions we can now write a program that takes user input and performs an addition, let's take a look at the following program:

``` assembly
READ 0x20000, R0, 0x0 // Read from keyboard, store in R0
READ 0x20000, R1, 0x0 // Read from keyboard, store in R1
ADD R0, R1, R2 // Add R0 and R1, store in R2
```

This is a bit more useful than our example in [Part 1](how-do-cpus-work-part1), it takes user input and adds it together, but how do we get the result? We can't just print it to the screen, we didn't define how to do that yet. We can store it in memory, but how do we know where to store it?

### Registers and Address Bus

If the registers are 16-bit in size, and the address bus is also 16-bit in size, how do we address the other components? There are several strategies that can be employed, such as not allowing for the full 16-bits to be used for RAM or another strategy is to have more than one bus controller, one for the memory and another for the other components, and the CPU can switch between them. The first strategy is the simplest, but it limits the amount of memory that can be used, the second strategy is more complex, but it allows for more memory to be used. 

In our example CPU, we can have the last 3-bits of the memory address serve as a code for what is being targeted as that would give us a total of 8 potential components, for example, if the last 3-bits are 0, then the memory is targeted, if the last 3-bits are 1, then the hard drive is targeted, if the last 3-bits are 2, then the PCI devices are targeted, and so on. This means that the memory can only be 8KB in size, but it allows for more components to be used.

## Introducing ROM: Read-only Memory

I've mentioned in [Part 1](how-do-cpus-work-part1) that typically a CPU starts executing instructions by looking at address 0 but we have our memory there. So let's complicate our scenario a bit more, we've already decided on the 13-bit address space for the memory but we're taking full advantage of it, we need to make some room for a ROM, so let's shorten a bit more and make it half.

Our ROM is a read-only bit of memory, it's non-volatile but it can hold the code we programmed into it, by taking another bit away from our memory space (and I mean RAM here) we're left with 4KB of RAM and we can now have 4 KB of ROM, we can use the ROM to store our program and the RAM to store the result.

## Saving to Memory

So we now have, from 0x0000 to 0x0FFF ROM space where we can store our program and from 0x1000 to 0x1FFF RAM space where we can store our result, 0x2000 for the keyboard. We can write the program and store it in the ROM available, and then we can execute it, the CPU will start executing at address 0x0000, it will read the instruction, decode it and execute it, it will read the next instruction, decode it and execute it, and so on. Because we know our memory starts at 0x1000 we can use a register to keep track of where the last memory available is, and we can use that to store the result of the addition (reminder we only have 5 registers available).

``` assembly
MOV R0, 0x1000 // Move the value 0x1000 to R0, our memory pointer
READ 0x20000, R1, 0x0 // Read from keyboard, store in R1
READ 0x20000, R2, 0x0 // Read from keyboard, store in R2
ADD R1, R2, R3 // Add R1 and R2, store in R3
WRITE R0, R3, 0x0 // Write to memory addr R0, the data R3 and the control bits 0x0
```

## Display: Adding a LCD screen

Now we have a program that can add two numbers and store the result in memory, but how do we know what the result is? We can't just look at the memory, we need to print it to the screen, but we don't have a screen, we only have a keyboard. So let's add a screen to our arquitechture, we'll add it at address 0x3000. How we communicate with the screen it will depend, we won't be talking about the monitor you're used to nowadays, let's focus on an LCD (Liquid Crystal Display), those little green screens typically with two rows of text available.

![Liquid Crystal Display](img/blog/content/technical/computers/how-do-cpus-work/liquid-crystal-display.png "Liquid Crystal Display")

### Defining the Liquid Crystal Display (LCD) protocol

These displays are very simple, but they require a precise set of instructions to work, they have a set of pins that are used to send data to the screen, and a set of pins that are used to send commands to the screen, the data pins are used to send the data that will be displayed on the screen, the command pins are used to tell the screen what to do, for example, to clear the screen, to move the cursor to a specific position, to turn the screen on or off, and so on. Usually you'll find the information about the pins and the communication protocol on the manufacturer manual, but for the sake of simplicity, let's assume that the communication protocol is as follows:
 - You send the command 0x0 followed by 0x1 to start up the screen
 - You send 0x2 to clear the screen, this will move the cursor to 0,0
 - You send 0x3 followed by the position you want to move the cursor, the first 8-bits carry the X and the last 8-bits carry the Y, note that the Y can only be 0 or 1 and the X can only be between 0 and 64
 - You send 0xF to write to the screen at the current cursor position, we need a way to define text so let's assume that we're using the ASCII table (8-bits), which fits well into our 16-bit data bus, in fact we can send two characters per operation! So we'll send the first character in the first 8-bits and the second character in the last 8-bits, and every character we write will move the cursor forward by one position, if the cursor is at the end of the line, it will move to the next line, if the cursor is at the end of the screen, it will move to the beginning of the screen.

### Writing to the Screen

Let's make our program more interactive by, asking for the inputs and printing the result to the screen:

``` assembly
MOV R0, 0x1000 // Move the value 0x1000 to R0, our memory pointer

// Start the screen
WRITE 0x3000, 0x0000, 0x0 // Send the command 0x00 to the screen
WRITE 0x3000, 0x0000, 0x1 // Send the command 0x01 to the screen

// Writes INPUT 1: to the screen
WRITE 0x3000, 0x0000, 0x2 // Clear the screen
WRITE 0x3000, 0x4E49, 0xF // Write IN to the screen
WRITE 0x3000, 0x5055, 0xF // Write PU to the screen
WRITE 0x3000, 0x2053, 0xF // Write T<space> to the screen
WRITE 0x3000, 0x3A31, 0xF // Write 1: to the screen

READ 0x20000, R1, 0x0 // Read from keyboard, store in R1

// Writes INPUT 2: to the screen
WRITE 0x3000, 0x0000, 0x2 // Clear the screen
WRITE 0x3000, 0x4E49, 0xF // Write IN to the screen
WRITE 0x3000, 0x5055, 0xF // Write PU to the screen
WRITE 0x3000, 0x2053, 0xF // Write T<space> to the screen
WRITE 0x3000, 0x3A32, 0xF // Write 2: to the screen

READ 0x20000, R2, 0x0 // Read from keyboard, store in R2

ADD R1, R2, R3 // Add R1 and R2, store in R3
WRITE R0, R3, 0x0 // Write to memory addr R0, the data R3 and the control bits 0x0

// Writes RESULT: to the screen
WRITE 0x3000, 0x0000, 0x2 // Clear the screen
WRITE 0x3000, 0x5245, 0xF // Write RE to the screen
WRITE 0x3000, 0x5355, 0xF // Write SU to the screen
WRITE 0x3000, 0x4C54, 0xF // Write LT to the screen
WRITE 0x3000, 0x3A20, 0xF // Write :<space> to the screen
WRITE 0x3000, R3, 0xF // Write the result to the screen
```

This is getting harder now to write now, makes you start to appreciate compilers, a huge thank you to [Grace Hopper](https://en.wikipedia.org/wiki/History_of_compiler_construction) who invented the first compiler.

## Subroutines (or Functions)

If we take a look at the previously written assembly code, we can see that we're writing to the screen a lot, and we're writing the same thing over and over again, we can simplify this by creating a subroutine (or as we call them today, a function), a subroutine is a set of instructions that can be called from anywhere in the program, and it will execute the instructions and return to the caller. We can create a subroutine that writes a string to the screen, and we can call it whenever we need to write something to the screen, this will make our program smaller and easier to read.

### The x86 Calling Convention

But how do we pass on arguments into the subrotine, and how do we get the result back? At this point, any method that we could divise would be fair game, we could use a predetermined set os registers: R0, R1, R2, R3 and R4 for arguments and R5 for the output, we could even reuse R0 as the output, overwritting whatever is there to have one more register available for arguments, as long as the caller knows it's going to happen but we could also use the memory RAM for this, and that is what happens nowadays. As this was a challenge every programmer faced and, if you wanted to share some assembly code with someone else, or if you wanted to call a subroutine defined by another developer, you could either both agree on how it should work, or you could use a convention, and that's what happened, there's a convention called [x86 calling conventions](https://en.wikipedia.org/wiki/X86_calling_conventions) that defines how arguments are passed to a subroutine and how the result is returned, and it's still used today. I'm not going into details about the convention, feel free to read the wikipedia article that does a decent job at explaining it, but it's a set of rules that are agreed upon by the caller and callee of every subroutine. This ensures that the caller does not lose critical registers when it's not expecting to, and it ensures that the callee knows where to find the arguments and where to store the result.

### Interoperability: The Key

This convention is followed by all modern compilers, if both the C and Golang compilers follow this convention, then you can call a C function from Golang and vice-versa, and that's how we can use libraries written in C from Golang and vice-versa, this works because at the assembly level the CPU does not care what high-level language you used to write the code, it only cares about the instructions that are being executed and the convention ensures that Golang and C functions can call eachother, but this will always depend on compilers supporting the feature. However the same cannot be said for C# and Java, this is because they run on a virtual execution environment, you can technically call functions in DLLs that were compiled in C, but that does not happen the same way it does for C and Golang, it's just something their respective virtual execution environment's support.

# Conclusion

Hopefully this post helped you understand how programs are executed on the CPU, and how the CPU communicates with other components, and how it can use the address space to communicate with other components. This is a very complex topic, and I've only scratched the surface, but I hope this helps you understand how the CPU works a bit better. 

If you take anything from this post, it's that CPUs can be anything its creators design them to be, we could create a 128-bit CPU today, or even a 32-bit capable of addressing 64-bit memory space, but every design decision has a trade-off, and it's up to the designers to decide what trade-offs they want to make. Modern CPUs are the result of decades of research and development, decisions on tradeoffs that are reevaluated every generation, but most importantly designed with compatibility in mind, compatibility with other components and with the choosen architecture. Apple's "recent-ish" decision to move from Intel to ARM is a good example of this, ARM is a newer architecture so the baggage from the past is much smaller, and by designing their own CPU they can decide which components to support and how that support will work, meaning they can optimize everything to their own liking and save on both monetary and performance costs.

For the next part I want to expand on the role of the operating system and how it manages the CPU and the memory, and how it allows multiple programs to run at the same time, so stay tuned for the next part.

If you have any questions, comments or suggestions, please let me know, I'm always looking to improve my writing and my knowledge.
Reach me at [Twitter](https://twitter.com/itspaletas), [GitHub](https://github.com/paletas), [LinkedIn](https://www.linkedin.com/in/joaosilvestre/) or via email at blog[at]itssilvestre.com.

# Small Nuggets of Computer History

The following topics are not relevant to the main point of the post but add some relevant context to it, so I'm adding them here as a bonus.

## Virtual Execution Environment Languages

The virtual execution environment were created to solve a small but noticeable problem for developers, if you've never worked with multiple environments you wouldn't have gone through this but if you write a C program and want it running on Linux for x86, x86-64 and ARM architectures you need to compile the program three times, even if the operating system is Linux for all of them, and you need to do it on a compatible machine (x86 can be compiled in a x86-64 machine, as the name indicates the x86-64 architecture was made to be compatible with it). This is because the CPU can only execute instructions that it understands, and the instructions for x86 are different from the instructions for x86-64 and ARM, so you need to compile the program for each architecture. 

This is not a large problem but it's still a problem for the developer, because it means that you need to have a machine with the same architecture as the target machine to compile the program, and that's where virtual machines come in. .NET and Java developed this intermediate executable that needs to be compiled for every architecture it wants to be compatible with. This executable then is able to execute compiled C# and Java code, both virtual machines defined their own intermediate language (IL) that is akin to assembly, but only understandable by the virtual machine execution agent and not by the CPU itself, the execution agent acts as a translator between IL and machine-code, but that translation comes at a cost of performance and memory.

## 32-bit Windows Could Only Use 3.5 GB of RAM

Let me prephase that this was eventually addressed on some of the last 32-bit CPUs, but it was a limitation at some point.

You read the title right, if you're not from the 32 bit era of computers and I know some of you might not be, you may not be aware of this. Now if you've been following allow, a 32-bit CPU should have 2^32 of address space available which is 4 GB, so why 3.5 GB? Well, for the same reason we had to reduce the memory in our own example CPU, to leave address space available for other components, in this case, the graphics card. The graphics card needs to have it's own memory, and that memory needs to be mapped to the address space of the CPU, so the CPU can send data to the graphics card and the graphics card can send data to the CPU. This is called DMA (Direct Memory Access), and it's a way for the CPU to send data to other components without having to wait for the component to be ready to receive the data, the CPU can just send the data to the component and the component will read it when it's ready.

However, not all 32-bit systems and CPUs were the same, we had examples of servers allowing up to 64 GB of RAM, they allowed this by having an address space on the bus of 36-bits. This means that the CPU could address 2^36 = 64 GB of RAM, but this was not the norm, and even then individual applications running on these systems could only use 4 GB of RAM but the system add more RAM to give every application running, avoiding having to do disc swaps (which are very slow, if you don't it's basically taking a piece of memory and storing it on the disc in order to free that memory space for other uses).

## Virtual Memory vs Physical Memory

If you were really really following along then you might have noticed, if on a 32-bit CPU the applications can only use 4 GB and the system can have up to 64 GB of RAM, how does the CPU address the RAM? The answer is that there's a concept called **Virtual Memory** which is a way for the CPU to address more memory than it's available, each application will have its own address space, and the CPU will map that address space to the actual address space of the RAM, this is done by the OS, and it's a very complex topic, but it's important to know that it exists. This also acts as a security feature because two applications running at the same time won't be able to access other applications memory, they will only be able to access their own memory. The trick played on those 64 GB systems was to map the 4 GB of address space of each application to a different 4 GB of the 64 GB of RAM available, this way each application could use 4 GB of RAM, and it would take longer before a disc swap needed to happen.

## The Beeping Keyboard

This is not common nowadays but have you ever had your computer get stuck, you continue to type away at the keyboard hoping that will solve it (it never does) and the computer starts beeping? That's a warning that the keyboard buffer is full, yes your keyboard also has memory, not literally inside the keyboard, but a small bit of computer memory is used to store the keys you press, and when the buffer is full, the computer will beep to warn you that it's full. A fast typer could fill the buffer pretty fast, faster than the CPUs at the time could read from it.

This is a very simple example of how the CPU communicates with other components, if the CPU tried to read directly from the keyboard two things needed to be true: CPU had to be faster at checking for key presses than the user typing, the user needed to have the key pressed in order for the CPU to read it. In order to avoid this headache, the keyboard has a small bit of memory that stores the keys pressed, and the CPU can read from that memory whenever it wants, and the keyboard will store the keys pressed until the CPU reads them. Everytime a key is pressed a signal will be sent to the CPU, called an interrupt (topic for the next post), and the CPU will read the key from the keyboard memory, and the keyboard will store the next key pressed, and so on. This way the CPU can read the keys pressed at it's own pace, and the user can type as fast as they want.

