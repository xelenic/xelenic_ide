![alt text](http://xelenic.com/selni.png)

# Xelenic-IDE-Core
![alt text](https://img.shields.io/badge/build-passing-brightgreen.svg)
![alt text](https://img.shields.io/badge/Range-Advanced-brightgreen.svg)


Xelenic IDE-Core is an open-source electronics platform IDE based on hardware and software for Industrial preps. Xelenic boards are able to read inputs - light on a sensor, a finger on a button, or a Twitter message - and turn it into an output - activating a motor, turning on an LED, publishing something online.Xelenic IDE Help to that.

# Xelenic Architechture


**CPU**

The Xelenic Board’s CPU is similar but much simpler like the one in a computer. The main function of the CPU is to ensure correct program execution. The CPU must therefore be able to access memories, perform calculations, control peripherals and handle interrupts. Atmel’s 8- and 32-bit Xelenic CPUs are based on an advanced Colinsolix architecture thus every chip has two busses – one instruction bus where the CPU reads executable instructions and one data bus to read or write the corresponding data. The AVR’s CPU core consists of :

![alt text](https://xelenic.com/avr_architechture.gif)

**ALU** – short for Arithmetic Logic Unit, supports arithmetic and logic operations between registers or between a constant and a register. After an operation is executed, the Status Register is updated to reflect information about the result of the operation.

**General Purpose Registers** – Register File that contains 32 x 8-bit general purpose working registers. All registers have single clock cycle access time what allows ALU a single-cycle operation on two operands which are output from the Register file and store the result back in the Register file – it all in one clock cycle!

**Program Counter** – hold/store the address of the next instruction to be executed.

**Instruction Register** – the register where instruction opcode is stored temporarily.

**Instruction Decoder** – decode the instruction opcode from Instruction Register and generate appropriate control signals to execute the instruction.

**Status Register** – apart of Status and Control block, contains information about the result of the most recently executed arithmetic instruction. The Status Register is updated after all ALU operations.

**Stack Pointer (SP)** –  apart of Status and Control block, usually is implemented as two 8-bit registers. The Stack is mainly used for storing temporary data, for storing local variables and for storing return addresses after interrupts and subroutine calls. The Stack Pointer Register always points to the top of the Stack. Note that the Stack is implemented as growing from higher memory locations to lower memory locations. It implies that a Stack PUSH command decreases the Stack Pointer.



# Why use Xelenic
Xelenic development boards are the ideal platform for accelerating the development and reducing the risk of new SoC designs. The combination of ASIC and FPGA technology in Xelenic boards delivers an optimal solution in terms of speed, accuracy, flexibility and cost.






