# DesignPatterns

Some selected design patterns examples, but firs some Object Oriented Basic and Principes.

## OO Basic
- Abstraction
- Encapsulation
- Polymorphysm
- Inheritance

## OO Principes
- Encapsulate what varies.
- Favor composition over inheritance.
- Program to interfaces, not implemementation.
 
## Strategy pattern

Strategy - defines a family of algorithms, encapsulates each one, and makes them interchangeable. Strategy lets the algorithm vary independently from clients that use it. 

With usage of desne principes we can:
- Encapsulate what varies, means identify the aspects of your application that vary and separate them from what stay the same.
- Program to interfaces, not implementation, means that super-class won't to know any of implementation details for behaviors implemented in separate classes (separate from super-class and sub-classes)
- Favor composition over inheritance - change behavior at runtime

Below mentionet examples [StrategyNavigator](/StrategyNavigator) and [StrategyDuck](/StrategyDuck ) are designed according Strategy Pattern.

### Navigator

SW design for "Navigator" example:
![Strategy in example Navigator](/Doc/UML/StrategyNavigator.JPG)

### Duck simulator

SW design for "Duck simulator" example:
![Strategy in example Duck](/Doc/UML/StrategyDuck.JPG) 
 
