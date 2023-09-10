# SOLID-Principles

This repository contains code snippets demonstrating the applications of the five SOLID Principles:
- Single Responsibility Principle
- Open-Closed Principle
- Liskov Substitution Principle
- Interface Segregation Principle
- Dependency Inversion Principle

The code snippets contained within the repository are inspired by the Udemy course entitled "Design Patterns in C# and .NET" by Dmitri Nesteruk would can be accessed via the following link: https://www.udemy.com/course/design-patterns-csharp-dotnet/

The code found within the repository was created as a console application written in C# with .Net 6.0 as the target framework. Every design principle is contained within it's own folder, with two seperate classes, namely the scenario class and the solution class. The scenario class demonstrates an implementation that breaks the target design principle, while the solution demonstrates the use of the design principle. A `Program.cs` class contains the main method from which the program is to be run. Code snippets in this file, seperated by appropriate comments, can be commented in and out to run use cases of the scenarios and solutions for each design principle. Some design patters are used within the examples, such as Decorator, Memento and Specification.

A quick summary for each design principle:

- Single Responsibility Principle:
  - Every class should have just a single reason to change, and too much responsibility should not be added to a single class.
  - This lends to the concept of 'seperation of concerns', where different classes should handle different, independant tasks.
  - This further lends to the object oriented idea of composition, where complex systems are built from a multitude of concerns, which interact and depend on one another.
- Open-Closed Principle
  - Classes should be open for extension, but closed off to modification.
  - It is a bad idea to add functionality to a class that has been written and tested, and is depended on, if it can be avoided.
  - Rather extened functionality by making use of interfaces, inheritence, dependency injection, and so forth.
- Liskov Substitution Principle
  - A base type should be able to be substituted by a sub-type.
  - Object oriented design requires that you can cast a descendant to it's base and store it in a variable of it's base and it should still operate correctly.
  - Make certain field, properties and methods virtual such that the correct member is accessed.
  - Consumers of an API might access either the base class or the descendant class.
- Interface Segregation Principle
  - Do not put too much in an interface, and rather split into multiple interfaces.
  - This is to prevent consumers of an interfaec to need to implement members which they do not require. (How would they handle this? - Logs? Throwing Exceptions? No-Ops?).
  - YAGNI + Seperation of Concerns.
- Dependency Inversion Principle
  - High level modules should not depend on low level modules.
  - Make use of abstractions, where the low level modules will implement the abstraction and the high level modules will consume the abstraction.
  - This follows object oriented design, where implementation details should not be exposed directly.

This project is intended to be used as reference material.

This project is complete and is unlikely to be updated again in future.
