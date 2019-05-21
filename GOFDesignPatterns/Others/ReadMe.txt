Null Object Pattern:- This uses example from the book Adaptive Code via C#: Agile coding with design patterns and SOLID principles

Its purpose to allow you to avoid accidentally throwing a NullReferenceException and also not to end up
with a lot of null object checking code.

e.g: Calling a UserRepository.GetUser(id) in your client code.
The probability of this method call returning a null User object, is very high.

We don't want to be burdening every client code that makes a call to this UserRepository.GetUser(id) method,
to have to do a null check in its code every time.

Rather, we fix this in the UserRepository class itself to handle null objects by returning a special kind of user,
called the NullUser (this will be a subclass from the base class of User).
This NullUser subclass should override any methods in the base class to do almost nothing, if called.

Additionally, whenever a method or property of the NullUser object is expected to return a
reference to another object, it should return a special Null Object implementation of those types, too.
In other words, all Null Object implementations should return recursive Null Object implementations.
This obviates the need for any null reference checking in clients.

This way, we will have all the null check unit tests in the UserRepository and not scattered through out all client code unit tests.

IsNull property anti-pattern
Sometimes the Null Object pattern involves adding a Boolean IsNull property to the interface. All
real implementations of this interface return the value false for this property. The Null Object implementation
of the interface returns true.

The problem with this property is that it causes logic to spill out of the objects whose purpose is to
encapsulate behavior. For example, statements will start to creep into client code to differentiate
if between real implementations and the Null Object implementation. This obviates the whole purpose of the pattern, 
which is to avoid proliferating this logic to its various clients