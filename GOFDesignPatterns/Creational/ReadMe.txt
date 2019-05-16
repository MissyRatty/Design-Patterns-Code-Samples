Factory:
Define an Interface for creating objects but let the subclasses decide which object instance to create.
This uses inheritance and delegates the object creation responsibility to the sub or derived classes.

When Do I need the Factory Pattern ?
- When you want a method to return one of possible classes that share a common super class, i.e: the class selection is decided at runtime.
- When you want to create objects without specifying the exact class of object that will be created.
- When you don't know ahead of time, what class object you need. However, make sure that all the possible return 
class objects have a common super class.
- When you want to centralize your class selection code so your client (main app) code doesn't need to know of every potential subclass.
- When you want to encapsulate object creation, i.e: have your objection creation methods and properties in a single class, and expose
its functionalites through access modifiers to code outside of the object creation class scope.
 
 
Abstract Factory:
Define an interface for creating a family of related or dependent objects and delegate the object creation responsibility
to another object through composition

NB:
Abstract Factory is like a factory(declares an interface for object creation but lets the sub or derived classes decide which object to instantiate), but everything is encapsulated.
- The client code that requests for the object is encapsulated.
- The factories that create the objects are also encapsulated.
- And the final object created is also encapsulated.

The final object contains objects that use composition (i.e: class fields are actually objects themselves))


When Do I need the Abstract Factory Pattern ?
- When you want to create a family of related objects without specifying a concrete class, which will allow you a lot of flexibility in object creation.
- When you want to have many objects that can be added or changed dynamically at runtime.


Builder:
Use the builder pattern to hide the construction process or details of an object away from the client code that uses it or its representation. 

When Do I need the Builder Pattern ?
- When the classes that use an object don't have to know the processes or details involved in an object's creation.
- When you want to have a single construction process that can create different representations of the same object.



Prototype:
Creating new objects or instances by copying or cloning existing objects or instances.

When Do I need the Prototype Pattern ?
- When you want to use to create any subclass instance of a known super class at runtime.
- When there are numerous potential classes that you will only need at runtime.
- When you want to reduce the need to have to create more subclasses.


E.g: I have a super class Person and a SubClass Bob. Using the prototype pattern, I can decide not to create a new sub class for John John, but rather, copy an instance of a Bob object into a John object. 

However, I will only do the above, if I only needed a John object which has the same props as the Bob object, and the John object was needed only at runtime. In this scenario, I wouldn't need to create a new Person subclass called John just for something only needed at runtime.



SingleTon:
Used when you want to only have one instance of the object through out the application's lifetime.

Issues:
Handling Multithreading
Add a double checking lock pattern with a lock object when deciding if a new object instance of the class, should be created, when its null.


E.g: A class holds all scrabble letters and spits out new ones upon request to a scrabble player.
All the scrabble players can share the same list of letters. 
However, each player will have their own list of letters to mess with to participate in the scrabble game.
