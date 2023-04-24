# Design Patterns

- Knowing the object oriented Basic does not make you a good object oriented designer.
- Good object oriented designs are reusable, extensible, and maintainable.
- Patterns show to you how to build systems with good object oriented design qualities.
- Patterns are proven object-oriented experience.
- Patterns don't give you code, they give you general solutions to design problems. You apply them to your specific application.
- Patterns aren't invented, they are discovered.
- Most patterns and principles address issues of change in software.
- Most patterns allow some part of a system to vary independently of all other parts.
- We often try to take what varies in a system and encapsulate it.
- Patterns provide a shared language that cans your communication with other developers.

### Object Oriented Basic
- Abstraction
- Encapsulation
- Polymorphysm
- Inheritance

### Object Oriented Principes
- Encapsulate what varies.
- Favor composition over inheritance.
- Program to interfaces, not implemementation.
- Try to for loosely coupled design between object that interact.
 
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

**UseCase:**
- Duck simulator application.
- SW design with easy maintainable (extensible and modification).
- Each duck-type have own approach how to do behavior (strategy): quack, swim, fly. Its realized in constructor.
```
public WildDuck() 
{
	QuackingStrategy = new DoQuack();
	SwimingStrategy = new DoSwim();
	FlyingStrategy = new DoFly();
}
```
- As duck realize behavior with delegate (composition with interface), it can be changed during runtime.
```
wildDuck.QuackingStrategy = new DoQuack();
wildDuck.Quack();
```

SW design for "Duck simulator" example:
![Strategy in example Duck](/Doc/UML/StrategyDuck.JPG) 
 
## Observer pattern

Observer - defines a one-to-many dependency between objects so that when one object (Subject) changes state, all of its dependents (Observers) are notified and updated automatically.

- Loosely coupled defines are much more flexible resistant to change.
- Subject update observers using common interface. That is only one thing which Subject knows.
- Do not depend on a specific order of notification for observers.

### Weather station

**UsueCase:**
- Observer pattern in implementation of weather station.
- Role of Subject is taken by *WeatherData* object which notify over method *Update()* registered observers.
- Observers are displays objects (*DisplayCurrent, DisplayStatistics, DisplayForecast*) which shows different weather data category.
- Observers can be added and removed in runtime.

SW design for "Weather station" example:
![Strategy in example Duck](/Doc/UML/ObserverWeather.JPG)
