---
title: "Understanding CPU Operation: A Programmer's Guide to program execution (Part 1)"
description: "Discover the inner workings of the CPU and how it brings programs to life."
summary: "An introduction to concepts related to program execution on the CPU, demystifying the process to programmers that don't know."
tags: 
  - processor
  - cpu
  - how does it work
  - computer architecture
draft: false
creationDate: 2023-08-15T00:00:00Z
updateDate: 2023-08-28T22:38:00Z
---

First things first, if you didn't know, CPU stands for central processing unit and it's far easier to type, a term I'll use for brevity.

## Introduction

Welcome to the first part of our series understanding how a CPU executes programs. In this part we'll go over the process that makes a program come to life within a CPU. If you're wondering why is this relevant to you as a programmer, software development works in layers and I've found in my experience that by understanding the layers below I'm able to be better at using, and understanding, the layer I'm working at. 

## Layers in Modern Software Development

When it comes to modern software development, we're dealing with a multi-layered landscape that's designed to make complex tasks more manageable. These layers serve as building blocks, each adding its own level of abstraction and functionality. By understanding these layers, we can navigate the intricacies of software development more effectively.

### Abstraction and Simplification

**CPUs and Machine Code**: At the foundational level, CPUs execute machine code—binary sequences that the hardware can interpret directly. However, crafting machine code can be challenging for humans, leading to the emergence of higher-level languages like Assembly. Assembly provides a text-based representation of machine code instructions, offering developers a more human-readable interface for programming.

**High-Level Languages**: As software development progressed, we moved beyond Assembly to higher-level languages like C. These languages introduced abstractions that made coding more intuitive. Compilers then translated this code into machine code, bridging the gap between human-friendly languages and hardware-level execution.

### Layered Development for Efficiency

**Compiler Magic**: The magic happens with compilers—the software responsible for translating high-level code into machine code. Compilers enable developers to express complex logic in ways that align with their thinking. The compiler takes care of mapping these expressions to the underlying machine code instructions, making the development process efficient and manageable.

**Operating System Abstraction**: Modern operating systems operate as a layer above the hardware, providing a bridge between applications and the CPU. They offer libraries that abstract complex operations, ensuring programmers don't need to worry about hardware specifics. Moreover, operating systems provide isolation between programs for security, ensuring one misbehaving program doesn't disrupt others.

**Network Layers**: The idea of layers extends to other domains, like networking. In networking, we have layers ranging from the physical layer that handles hardware signals to the application layer that deals with user interfaces. This layered approach simplifies network communication by breaking down complex processes into manageable steps.

### Striking a Balance

While layers enhance development efficiency, they also create a challenge. Layers abstract lower-level details, shielding developers from complexity. However, this can be a double-edged sword when debugging or understanding how things work under the hood. Striking a balance between abstraction and understanding is key to becoming a proficient developer who can harness these layers effectively.

By grasping the concept of layers, we gain insight into how our programs interact with the underlying hardware and systems. This understanding empowers us to write better code, optimize performance, and navigate the complexities of software development more adeptly. It is far too often that I meet developers that know how to write code but seem totally obliviously to how a computer works and why things work the way they do, and I think that's a shame. As programmers we're not just users of the computer. but we're part of its development, extending its capabilities by writing custom software, and we should know how it all works, at least at a high level.

## Disclaimer
Before we move on onto the explanation, the following explanations and examples will be based on a fictitious and simple CPU. Modern CPUs are complex pieces of hardware that rely on several years of development, concepts and techniques, so to make it easier to understand, we'll be using a CPU that only has the most basic features, and we'll be using a simplified instruction set, so that we can focus on the concepts and not on the details.

## The CPU: More Than Just the "Brain"

If you know about computers you should already know what the CPU is, many call it the brain of the computer, but that's not really true, it's more akin to the heart, it's the piece of hardware that makes everything else work, by executing user-provided instructions.

CPUs nowadays can perform anything from very data movement to complex ones cryptographic operations, this allows applications to execute faster as the hardware is able to perform this operations faster than if they were implemented in software, and it also allows for more complex applications to be developed, as the CPU can perform operations that would be too complex (time complexity) to be done in software.

## Unveiling the Execution Process
### Key Concepts to Master
So in order to understand how it works, we need to lay out a few concepts first. 

1. **Instruction**: The first one is the instruction, an instruction is an operation that is built into the CPU die (chip), and it represents the capabilities the CPU has. An instruction can be something like "add two numbers", "move data from memory to register", "jump to a specific memory address", etc.
   
   An instruction will be documented and will have a name, and it will have a specific format that must be placed in a registry, so that the CPU may look at it and understand what must be done. Part of the instruction definition will be the parameters it takes, also defined in registers, so OP1 which is an ADD may require the operand 1 to be in the register R1 and the operand 2 to be in the register R2, and will output the result into the register R3. So a program that adds three numbers may look like this in Assembly (this is a simplified illustrative example, real assembly instructions will have a specific format and parameters, decided by the specific instruction set in use):   
   ```assembly
   // Add 1, 2 and 3 together and store the result in R1
   MOV R1, 1 // Stores the value 1 in R1
   MOV R2, 2 // Stores the value 2 in R2
   ADD R1, R2, R3 // Adds the values in R1 and R2 and stores the result in R3
   MOV R4, 3 // Stores the value 3 in R4
   ADD R3, R4, R5 // Adds the values in R3 and R4 and stores the result in R5
   MOV R1, R5 // Stores the value in R5 in R1
   ```

   Assembly is the lowest level of language we have, but even assembly is compiled into machine code, which is just a bunch of binary data that is loaded and executed by the CPU. See the following example of how that might be structured:

   ![diagram showing machine code](img/blog/content/technical/computers/how-do-cpus-work/machine-code.png "Low Level Code to Machine Code diagram")
	
   In the example above, you can see, two of the instructions we used above, it's showing those instructions in hexadecimal notation as they would be in machine code, I used the first 4 bits to represent the instruction being used, like an operation code, and then the following 12 bits for parameters, this is very suboptimal but great for showing off. The add has three arguments, 4 bits each, representing the registers R1, R2 and R3, and the move has two arguments, 4 bits for the register and 8 bits for the constant value. This is a simplified example, but it shows how the CPU can understand the instructions and execute them.

1. **Instruction Set**:	Then we have the instruction set, that is the collection of all operations a certain CPU can perform, now this is not per CPU, otherwise companies like Microsoft, that makes an operative system capable of running on hundreds of CPUs would be unable to support so many of them. There are standard instruction sets that rule which operations are available and how they work, so that any CPU that implements that instruction set can run the same code. The most common instruction set nowadays is the x86-64, which is the one used by Intel and AMD CPUs, but there are others, like ARM, RISC-V, etc. ARM is a licensable instruction set and CPU designer that is used by many producers, while RISC-V aims to be an open-source CPU arquitechture.
1. **Program**: The next concept is the program, a program is a collection of instructions that are executed in order to perform a certain task. A program can be anything from a simple calculator to a complex video game.
1. **Clock and Clock Speed** Have you ever bought a computer, or a CPU, and saw that it has a clock speed of 4GHz? Well, that's due to a component called the clock generator or crystal oscillator. It's a piece of hardware that generates a signal at a certain frequency, and that signal is used to synchronize all the other components of the CPU. This is important because it means that the CPU can only perform one operation per clock cycle, so if the clock is running at 4GHz, it can only perform 4 billion operations per second. This is why clock speed is so important, the higher the clock speed, the more operations the CPU can perform per second. However, note that instructions take more than one clock cycle to execute, and different instructions can take different amounts of clock cycles, so the clock speed is not the only thing that matters, but it's a good indicator of how fast a CPU is.
1. **Register**: It's a very small piece of memory that is inside the CPU, and it's used to store data that is being used by the CPU. Registers are very fast, but they are also very small, so they are used to store data that is being used very often, like the result of an operation, or the data that is being operated on. Registers are also very important because they are the only way for the CPU to interact with the outside world, so if you want to read data from memory, you need to load it into a register, and if you want to write data to memory, you need to write it from a register. There are some special registers with specific purposes such as the PC register, stands for program counter and has the address for the next instruction to be loaded, and the IR register, stands for instruction register and is used to store the instructions that are being executed by the CPU.

### Exploring CPU Architecture

CPUs architectures define the instruction set, the size and number of the registers, the memory address size, etc. There are many CPU architectures, but the most common ones are x86, x86-64/AMD64 and ARM. Let's take a look at the x86-64 arquitechture, it was initially created by Intel, but it's now used by both Intel and AMD CPUs (usually called AMD64, but they're **mostly** similar). It has a known instruction set (however support varies by CPU as they keep introducing new instructions as CPUs evolve), it defines the size of the registers (64 bits), the number of registers (16), the memory address size (64 bits), etc. Memory address size is usually the same as the register size (even if it's not always the case) because when you want to read data from memory, you need to load the address into a register, and if the register is smaller than the memory address, you won't be able to read the correct address.

### Navigating the Execution Cycle

So now that we have all the concepts we need, let's see how it all comes together. Let's say we have a CPU that has 5 registers, 16 bits each, and a memory address size of 16 bits. This means that the CPU can only read 64 KB of memory, because 2 ^ 16 = 65536, and 65536 / 1024 KB = 64 KB (32 bits registers are able to handle 4 GB of memory, and 64 bits are able to reach 16 EB, which is 16 exabytes and more than enough for today's needs).

Once started, the CPU will generally be looking at the address 0 to look for it's first instruction, this address will be stored inside a special register meant to hold the current program memory address (*PC*, program counter). It's not uncommon for this address to contain just be a piece of code that then decides where the actual application is, often called a bootloader. But to understand how does the CPU actually execute anything, for that we need to revisit the concept of clock, see a clock is a digital signal that goes from 0 to 1 and back to 0, every time the clock goes to 1 (or 0 doesn't really matter I believe, so let's assume a 1 for now), every of the following bullets will happen at every clock cycle and it starts from boot (address 0x0000):
 1. Load the instruction at the address stored in the PC register into the instruction register (*IR*).
 1. Increment the *PC* register by one (this is a simplification, in current CPUs instructions may have different sizes).
 1. Decode the instruction in the *IR* register, this means looking at the instruction set and understanding what the instruction means and what it does.
 1. Execute the instruction, this means performing the operation the instruction is meant to do, like adding two numbers, moving data from memory to a register, etc.

 This is typically called the "fetch-decode-execute cycle" and will happen for every instruction in the program. The above steps are just a massive loop that the CPU will keep on executing until it's turned off, it's that simple. Here we're assuming every step happens sequentially, and every instruction too, but in modern day CPUs there's also a different technique called "pipelining" that allows the CPU to start executing the next instruction before the current one is finished, but again, for simplification sake let's assume a sequential order in our examples.

Each step may take one or more clock cycles to execute, would be safe to assume that loading the instruction and incrementing the PC register takes one clock cycle, while decoding and executing the instruction may take more than one, but again, decoding maybe takes a fixed amount of clock cycles but execution will vary depending on the instruction. In modern CPUs there will often exist many ways of accomplishing the same task, it's up for the compilers to choose the instructions that take the least amount of clock cycles to improve application performance. This is also why CPUs of newer generations may be faster than older generations, even when they have the same clock speed, they may support new instructions that are faster to execute and that can be used by the compiler to improve performance, even if it requires the application developer to release a new version.

## Part Conclusion

As this part comes to an end I hope that you can now have a better understanding of how a program is executed by the CPU, and how the CPU works in general. This is the foundation of knowledge that I believe has enabled me to be a better employee, a better colleague and ultimately a better software engineer.

In the next part we'll take a look at how the CPU interacts with the rest of the computer.

If you have any questions, comments or suggestions, please let me know, I'm always looking to improve my writing and my knowledge.
Reach me at [Twitter](https://twitter.com/itspaletas), [GitHub](https://github.com/paletas), [LinkedIn](https://www.linkedin.com/in/joaosilvestre/) or via email at blog[at]itssilvestre.com.