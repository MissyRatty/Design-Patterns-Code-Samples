Mediator:
Defines an object that encapsulates how a set of objects (related objects) interact.
It promotes loose coupling by preventing the set of objects to have an explicit reference to each other.
Also, with the mediator, I can vary the interaction independently.

Participants:
Colleague: A common interface for all the set of related objects that need to interact with each other.

Concrete Colleagues: The set of objects that need to interact with each other.
Each colleague object knows its mediator object.
Each colleague object communicates with its mediator whenever it needs to communicate with another colleague object.

Mediator: A common interface for communicating with Colleague Objects

Concrete Mediator: Knows and maintains its colleagues. (i.e: knows the colleague objects its mediating).

NB:
All communication is handled by the mediator and the colleagues don't need to know anyting about each other.




Visitor:
Represents an operation to be performed on the elements of an object structure.
Use visitor to define a new operation without changing the classes of the elements on which it operates.

Participants:
Element : has an accept method which takes a visitor as an argument (Accept(visitor)).
Concrete Element: they implement the Element interface's Accept operation which takes a visitor as an argument.
Object Structure: an object that can enumerate it self, e.g : a List or set of items.

Visitor: declares a visit operation for each concrete element in the object structure.
The name and signature of this visit operation or method makes the visitor aware of which concrete element class made a request
for a visitor and also lets the visitor decipher which concrete element class it needs to visit.
so basically, lets us know where the visit request is sent from and where the visit response is going to.
Once the visitor knows which concrete element class to visit, it will access that element directly through its particular interface.

		 
ConcreteVisitor: implements the visit operations in the Visitor interface.
Provides the context for the visit operations algorithm and stores its local state.
This local state, will be accumulating results whilst we go through the object structure.



Strategy:
Define a family of algorithms, encapsulate each one, and make them interchangeable.
Strategy lets you vary your algorithm independently of the clients that use them.
This is because, your algorithms have been encapsulated and abstracted from your client code that uses these algorithms,
therefore, you can go and make changes to any of these algorithms and you won't have to change your client code.
NB: Encapuslate an algorithm inside a class.

you will then use your strategy interface as an instance (object) variable or reference in your Base class and dynamically
change that instance variable to be of any of the concrete strategy classes.

You can now create many strategies without having to affecting any existing classes.
 Decoupling : encapsulating the concept or behavior that varies. (e.g animals ability to fly)





When ?
- when you want to define a class with one behavior that is similar to other behaviors in a list. e.g: Animals that can fly and those that can't fly
- when you need to use one of several behaviors dynamically.
- often reduce long lists of conditionals
- eliminate code duplication
- keeps class changes from forcing other class changes.
- hides complicated or secret code from the user.


Negative:
Increased number of objects / classes
