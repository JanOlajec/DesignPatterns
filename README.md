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

**UseCase:**
- Program shoud prepare route navigation based on sleected navigaton strategy (ByCar, ByBicycle, ByWalk).
- On the begining, the Navigator object is without navigate strategy.
```
Navigator navigator = new Navigator();
```
- User select navigation strategy during runtime and call *BuildRoute()* mthod for building route.
```
navigator.routeStrategy = new ByCar();
navigator.BuildRoute("A", "B");
navigator.BuildRoute("C", "D");
```
- User can than change navigation strategy during runtime, e.g. for *ByBicycle()*.
```
navigator.routeStrategy = new ByBicycle();
navigator.BuildRoute("E", "F");
```

SW design for "Navigator" example:
![Strategy in example Navigator](/Doc/UML/StrategyNavigator.JPG)

### Duck simulator

SW design for "Duck simulator" example:
![Strategy in example Duck](/Doc/UML/StrategyDuck.JPG) 
 
