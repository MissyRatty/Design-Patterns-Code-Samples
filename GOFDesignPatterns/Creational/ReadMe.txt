Abstract Factory:
Define an interface for creating a family of related or dependent objects and delegate the object creation
to another object. This is just like the factory method, but everything is encapsulated.

Creates an object instantiation of a family of related or dependent classes.
It delegates the creation of the objects to another object through composition.


NB:
Like a factory(declares an interface for object creation but lets the sub or derived classes decide which object to instantiate), but everything is encapsulated.
- The client code that requests for the object
- The factories that create the object
- final object created is also encapsulated.

The final object contains objects that use the strategy pattern (it uses composition (ie class fields are actually objects themselves))


Importance
- create family related objects without specifying a concrete class. You get tone of flexibility.
- You want to have many objects that can be added or changed dynamically at runtime
- Bad thing is it can get complicated.


Builder:
Hiding the construction of an object away from the client code that uses it. 
So the clases that use it won't have to know or be responsible for the building of these objects.
 
Separate the construction of a complex object from its representation so that the same 
construction process can create different representations.


Factory:
Define an Interface for creating objects but let the subclasses decide which object instance to create.
This uses inheritance and delegates the object creation to the sub or derived classes.

Use this when you want a method to return one of possible classes that share a common super class.
Classes chosen at runtime.

It allows you to create objects without specifying the exact class of object that will be created.


- When you don't know ahead of time, what class object I need. However, make sure that all the possible return 
class objects have a common super class.

- Centralize class selection code when you don't want the user to know of every potential subclass.

- Encapsulate Object Creation.



Prototype:
Creating new objects or instances by copying or cloning existing objects or instances.

- You can use the prototype pattern to create any subclass instance of a known super class at runtime.
- When there are numerous potential classes you will only need at runtime.
- Reduces the need to have to create more subclasses.


eg: I have a super class Person and a SubClass Bob. Using prototype pattern, I may decide not to have to create a John sub class,
but rather copy an instance of the Bob subclass to create a John object. 
NB: if only I needed a John object which has the same props as the Bob object, and the John object was needed at runtime only.
Therefore, I wouldn't need to create a new subclass just for something only needed at just runtime.



SingleTon:
Used when you want to only have one instance of the object at all times.

Issues:
Handling Multithreading
Add a double checking process with a lock object when creating new instance of the class

eg: A class holds all scrabble letters and spits out new ones upon request to all different users.
All users can share the same list of letters. However, each player will have a list of letters to mess with.