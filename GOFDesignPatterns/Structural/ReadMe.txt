Adapter:
Converts the interface of a class into another interface that the client code expects. 
This allows classes which couldn't communicate or work together due to incompatible interfaces, 
to work together.

You do this by creating a class that bridges the gap between an expected interface and an existing class.

The Adapter Pattern Components:
- "Target Class" : This is the expected interface your client code wants to communicate with.

- "Adapter Class" : This is the class that will act as a translator between your existing class and the expected interface for
  your client code. It inherits from the Target class, and also keeps a reference to the existing class (Adaptee). 
  This way, it can perform the actions from the "Target Class" on the object reference.

- "Adaptee Class" : This is the existing class you want to reuse, but its current state is incompatible with your client code.


When Do I need the Adapter Pattern ? 
- When you want two (2) incompatible interfaces to work together. 


Good Thing:
You won't need to change your existing class or interface when using the Adapter pattern, but rather reuse
your existing class.


Decorator:
Modify an object dynamically (runtime). 
That is, attach additional responsibilities to an object dynamically (at runtime).
Provides a flexible alternative to subclassing for extending functionality.

When ?
- you want the capabilities of inheritance with subclasses, but you need to add functionality at run time.
- more flexible than inheritance:
   - when inheritance, we will have like a base class eg: pizza then sub class threeCheesePizza which extends base class pizza.
     This will mean we will have to create an infinite number of pizzatypes sub classes.
   - If a method changes, e.g getCostOfPizza(), now determines its price from a type of topping (e.g ham), then, we will have to change the implementation of
   getCostOfPizza() in all the pizzatypes sub classes.

   Main problem is that : inheritance is static whilst composition is dynamic. With composition, you can add new functionality by adding new code and not 
   rewriting old code.
 
 
- simplifies code cause you add functionality by using many simple classes
- instead of rewriting or modifying old code, you can rather extend it with new code and keep your old code the same way it was before.



Facade (Has a High Frequency of use):
It defines a higher-level interface that makes the subsystem easier to use.
It provides a unified interface to a set of interfaces in a subsystem.

- Facade Interface knows which subsystem classes are responsible for each request it receives.
- Facade Interface will delegate client requests to the appropriate subsystem objects.

- The subsystem classes don't know about the facade and doesn't keep any reference to it either.
- The subsystem classes handles work assigned to them by the facade object.

When ?
- you want a simplified interface that performs many other actions behind the scenes. 

Sample Code Scenario:
This asks the application the question, "Can I withdraw £50 from the bank ?"
 - the application will have to do the following to respond to this request :

 => Check if the checking account is valid ?
 => Check if the security code is valid ?
 => Check if the funds are available to withdraw £50 from it ?
 => Make changes accordingly depending on the outcome of the checks above.

 Our application should be able to do the above seamlessly.