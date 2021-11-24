# Overview
The purpose of this repository is to illustrate various design patterns via C# implementations which developers can relate to. Each implementation can be found under it's corresponding directory within the DesignPatterns project. Every pattern will have a Client.cs file which illustrates the usage of the pattern.

Note that while the XUnit project was added and tests were created these are by no means intended as a guideline for what good unit tests would look like, simply as a convenient way of allowing people to download the source and debug a pattern should they choose.

For more information on software design patterns, wikipedia has some great overviews and content (some of which will be duplicated here for ease of reference): https://en.wikipedia.org/wiki/Design_Patterns  

[![dotnet package](https://github.com/joe-meyer/design-patterns/actions/workflows/push.yml/badge.svg)](https://github.com/joe-meyer/design-patterns/actions/workflows/push.yml)

## Creational
Creational patterns are ones that create objects, rather than having to instantiate objects directly. This gives the program more flexibility in deciding which objects need to be created for a given case.

* TODO: Abstract Factory groups object factories that have a common theme.
* [Builder constructs complex objects by separating construction and representation.](DesignPatterns/Creational/Builder/Client.cs)
* TODO: Factory Method creates objects without specifying the exact class to create.
* TODO: Prototype creates objects by cloning an existing object.
* [Singleton restricts object creation for a class to only one instance.](DesignPatterns/Creational/Singleton/Client.cs)

## Structural
These concern class and object composition. They use inheritance to compose interfaces and define ways to compose objects to obtain new functionality.

* TODO: Adapter allows classes with incompatible interfaces to work together by wrapping its own interface around that of an already existing class.
* TODO: Bridge decouples an abstraction from its implementation so that the two can vary independently.
* TODO: Composite composes zero-or-more similar objects so that they can be manipulated as one object.
* TODO: Decorator dynamically adds/overrides behaviour in an existing method of an object.
* TODO: Facade provides a simplified interface to a large body of code.
* TODO: Flyweight reduces the cost of creating and manipulating a large number of similar objects.
* TODO: Proxy provides a placeholder for another object to control access, reduce cost, and reduce complexity.


## Behavioral
Most of these design patterns are specifically concerned with communication between objects.

* TODO: Chain of responsibility delegates commands to a chain of processing objects.
* TODO: Command creates objects that encapsulate actions and parameters.
* TODO: Interpreter implements a specialized language.
* TODO: Iterator accesses the elements of an object sequentially without exposing its underlying representation.
* TODO: Mediator allows loose coupling between classes by being the only class that has detailed knowledge of their methods.
* TODO: Memento provides the ability to restore an object to its previous state (undo).
* TODO: Observer is a publish/subscribe pattern, which allows a number of observer objects to see an event.
* TODO: State allows an object to alter its behavior when its internal state changes.
* TODO: Strategy allows one of a family of algorithms to be selected on-the-fly at runtime.
* TODO: Template method defines the skeleton of an algorithm as an abstract class, allowing its subclasses to provide concrete behavior.
* TODO: Visitor separates an algorithm from an object structure by moving the hierarchy of methods into one object.