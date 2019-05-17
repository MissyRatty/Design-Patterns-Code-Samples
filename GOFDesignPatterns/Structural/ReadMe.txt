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


