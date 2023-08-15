---
title: "Demystifying CPU Operation: A Programmer's Guide to Program Execution (Part 1)"
description: "Explaining how a CPU works and how it executes a program"
summary: "An introduction to concepts related to program execution when working close to machine code, and how does concepts relate to how a CPU executes a program."
tags: 
  - processor
  - cpu
  - how-does-it-work
draft: false
creationDate: 2023-08-15
---

First things first, if you don't know, CPU stands for central processing unit and it's far easier to type, so I'll be using that from now on.

## Introduction

Welcome to the first part of our series understanding how a CPU executes programs. In this part we'll go over the process that makes a program come to life within a CPU. If you're wondering why is this relevant to you as a programmer, software development works in layers and I've found in my experience that by understanding the layers below I'm able to be better using, and understanding, the layer I'm working at. 

### Layers in modern software development 
Consider the following: CPUs execute machine code, sequences of binary that mean something to it, because this is hard for us humans to use directly, we use higher level languages, started with Assembly (A lang) which is just a text representation of that machine code, and then we went into B lang and then C lang which made it easier  this is often accomplished by using a compiler, a software that takes higher level languages and converts them into machine code. While C is not necessarily a layer above Assembly, it certainly is a layer above machine code, which in turn can be seen as a layer above the CPU. Modern operative systems also work as a layer, they provide libraries that abstract certain operations and standardize them, so that programmers don't have to worry about the specifics of the hardware they're working on, and they also provide a layer of security and isolation between programs, so that they can't interfere with each other.

Same happens in networking, where we have the hardware, then we have the physical layer, then the data link layer, then the network layer, then the transport layer, then the application layer, and so on. By working in layers, software development takes complex operations and makes them easier to understand and use, but it also hides the complexity of the lower layers, which can be a problem when you need to understand how something works, or when you need to debug something.

This wasn't always the case, we started by using specific purpose chips that were designed to perform a certain operation (think basic digital calculators), but we also have general purpose CPUs that can perform a wide variety of operations. Specific purpose should always be faster, as the hardware can be optimized for that use case, but with the rise of generic purpose computing, CPUs gained a lot of traction, and they're now the most common way to do computation.

### Getting ahead: Understanding the layers below
So, as I said, by understanding the layers below you can be better at the layer you're working at, so what better to place to start than at the base layer, the hardware that makes it all possible, the CPU. It's far to often that I meet developers that know how to write code but seem totally obliviously to how a computer works and why things work the way they do, and I think that's a shame. As programmers we're not just a user of the computer but we're part of it's development, extending it's capabilities by writting custom software, and we should know how it all works, at least at a high level.

## Disclaimer
Before we move on onto the explanation, the following explanations and examples will be based on a ficticious and simple CPU. Modern CPUs are super complex pieces of hardware that rely on several years of development, concepts and techniques, so in order to make it easier to understand, we'll be using a very simple CPU that only has the most basic features, and we'll be using a very simple instruction set, so that we can focus on the concepts and not on the details.

## The CPU: More Than Just the "Brain"

If you know computers you should already know what the CPU is, many call it the brain of the computer, but that's not really true, it's more like the heart, it's the piece of hardware that makes everything else work, by being able to execute instructions provided by a user.

CPUs nowadays can perform anything from very data movement to complex ones cryptographic operations, this allows applications to execute faster as the hardware is able to perform this operations faster than if they were implemented in software, and it also allows for more complex applications to be developed, as the CPU can perform operations that would be too complex (time complexity) to be done in software.

## Unveiling the Execution Process
### Key Concepts to Master
So in order to understand how it works, we need to lay out a few concepts first. 

1. **Instruction**: The first one is the instruction, an intruction is an operation that is programmed into the CPU die, and it's the most basic operation the CPU can perform. An instruction can be something like "add two numbers", "move data from memory to register", "jump to a specific memory address", etc.
   
   An instruction will be documented and will have a name, and it will have a specific format that must be placed in a registry, so that the CPU may look at it and understand what must be done. Part of the intruction definition will be the parameters it takes, also defined in registers, so OP1 which is an ADD may require the operand 1 to be in the register R1 and the operand 2 to be in the register R2, and will output the result into the register R3. So a program that adds three numbers may look like this in Assembly (this is a simplified illustrative example, real assembly instructions will have a specific format and parameters, decided by the specific instruction set in use):
   
   ```
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
	
In the example you can see two examples of the two instruction we used above, it's showing the instructions in hexadecimal, I used the first 4 bits to represent the instruction being used, and then the following 12 bits for parameters, this is very suboptimal but great for showing off. The add has three arguments, 4 bits each, representing the registers R1, R2 and R3, and the move has two arguments, 4 bits for the register and 8 bits for the constant value. This is a very simple example, but it shows how the CPU can understand the instructions and execute them.

1. **Instruction Set**:	Then we have the instruction set, that is the collection of all operations a certain CPU can perform. Now this is not per CPU, otherwise companies like Microsoft, that makes an operative system capable of running on hundreds of CPUs would be unable to support so many of them. There are standard intruction sets that rule which operations are available and how they work, so that any CPU that implements that instruction set can run the same code. The most common instruction set nowadays is the x86-64, which is the one used by Intel and AMD CPUs, but there are others, like ARM, RISC-V, etc. ARM is a licensable instruction set and CPU designer that is used by many producers, while RISC-V aims to be an open-source CPU arquitechture.
1. **Program**: The next concept is the program, a program is a collection of instructions that are executed in order to perform a certain task. A program can be anything from a simple calculator to a complex video game.
1. **Clock and Clock Speed** Have you ever bought a computer, or a CPU, and saw that it has a clock speed of 4GHz? Well, that's due to a component called the clock generator or crystal oscillator. It's a piece of hardware that generates a signal at a certain frequency, and that signal is used to synchronize all the other components of the CPU. So if the clock is running at 4GHz, that means that it generates a signal 4 billion times per second. This is important because it means that the CPU can only perform one operation per clock cycle, so if the clock is running at 4GHz, it can only perform 4 billion operations per second. This is why clock speed is so important, the higher the clock speed, the more operations the CPU can perform per second. However, not all operations and instructions are not the same thing, one instruction may take on clock cycle to execute, while another may take 10, so the clock speed is not the only thing that matters, but it's a good indicator of how fast a CPU is.
1. **Register**: It's a very small piece of memory that is inside the CPU, and it's used to store data that is being used by the CPU. Registers are very fast, but they are also very small, so they are used to store data that is being used very often, like the result of an operation, or the data that is being operated on. Registers are also very important because they are the only way for the CPU to interact with the outside world, so if you want to read data from memory, you need to load it into a register, and if you want to write data to memory, you need to write it from a register. There are some special registers with specific purposes such as the PC register, stands for program counter and has the address for the next instruction to be loaded, and the IR register, stand for intruction register and is used to store the instructions that are being executed by the CPU.

### Exploring CPU Architecture

CPUs arquitechtures define the instruction set, the size and number of the registers, the memory address size, etc. There are many CPU architectures, but the most common ones are x86, x86-64 and ARM. Let's take a look at the x86-64 arquitechture, it was initially created by Intel, but it's now used by both Intel and AMD CPUs (usually called AMD64, but they're **mostly** the same). It has a known instruction set (however support varies by CPU as they keep introducing new instructions as CPUs evolve), it defines the size of the registers (64 bits), the number of registers (16), the memory address size (64 bits), etc. Memory address size is usually the same as the register size (but it's not always the case) because when you want to read data from memory, you need to load the address into a register, and if the register is smaller than the memory address, you won't be able to read the correct address.

### Navigating the Execution Cycle

So now that we have all the concepts we need, let's see how it all comes together. Let's say we have a CPU that has 5 registers, 16 bits each, and a memory address size of 16 bits. This means that the CPU can only read 64 KB of memory, because 2 ^ 16 = 65536, and 65536 / 1024 KB = 64 KB (32 bits registers are able to handle 4 GB of memory, and 64 bits are able to reach 16 EB, which is 16 exabytes and more than enough for today's needs).

Once started the CPU will generally be looking at the address 0 to look for it's first instruction, this address will be stored inside a special register meant to hold the current program memory address (PC, program counter). It's not uncommon for this address to contain just be a piece of code that then decides where the actual application is, often called a bootloader. But to understand how does the CPU actually execute anything, for that we need to revisit the concept of clock, see a clock is a digital signal that goes from 0 to 1 and back to 0, every time the clock goes to 1 (or 0 doesn't really matter I believe, so let's assume a 1 for now), every of the following bullets will happen at every clock cycle and it starts from boot (address 0x0000):
 * Load the instruction at the address stored in the PC register into the instruction register (IR).
 * Increment the PC register by one (this is a simplification, in current CPUs instructions may have different sizes).
 * Decode the instruction in the IR register, this means looking at the instruction set and understanding what the instruction means and what it does.
 * Execute the instruction, this means performing the operation the instruction is meant to do, like adding two numbers, moving data from memory to a register, etc.

 This is typically called the "fetch-decode-execute cycle" and will happen for every instruction in the program. The above steps are just a massive loop that the CPU will keep on executing until it's turned off, it's that simple. Here we're assuming every step happens sequentially, and every instruction too, but in modern day CPUs there's also a different technique called "pipelining" that allows the CPU to start executing the next instruction before the current one is finished, but again, for simplification sake let's assume a sequential order in our examples.

Each step may take one or more clock cycles to execute, would be safe to assume that loading the instruction and incrementing the PC register takes one clock cycle, while decoding and executing the instruction may take more than one, but again, decoding maybe takes a fixed amount of clock cycles but execution will vary depending on the instruction. In modern CPUs there will often exist many ways of accomplishing the same task, it's up for the compilers to choose the instructions that take the least amount of clock cycles to improve application performance. This is also why CPUs of newer generations may be faster than older generations, even when they have the same clock speed, they may support new instructions that are faster to execute and that can be used by the compiler to improve performance, even if it requires the application developer to release a new version.

## Part Conclusion

As this part comes to an end I hope that you can now have a better understanding of how a program is executed by the CPU, and how the CPU works in general. This is the foundation of knowledge I truly believe has allowed me to be a better employee, a better colleague and ultimately a better software engineer.

In the next part we'll take a look at how the CPU interacts with the rest of the computer.

If you have any questions, comments or suggestions, please let me know, I'm always looking to improve my writing and my knowledge.
Reach me at [Twitter](https://twitter.com/itspaletas), [GitHub](https://github.com/paletas), [LinkedIn](https://www.linkedin.com/in/joaosilvestre/) or via email at blog[at]itssilvestre.com.