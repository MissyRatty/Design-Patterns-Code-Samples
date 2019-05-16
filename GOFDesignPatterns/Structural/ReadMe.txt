Adapter:
Converts the interface of a class into another that the client code expects. This allows classes which couldn't communicate or work together
due to incompatible interfaces, to be able to work together.

You do this by creating a class that bridges the gap btn an expected interface and an existing class.

- Expected Interface (Target, provides an interface that the client expects),
- Adapter Class (it implements the Expected Interface (target), and keeps a ref to the existing class like a field,
  and it performs the actions from the target interface on the ref to the existing class field (it uses composition)), 
- Existing Class (Adaptee, which is the class I want to reuse)

Allows 2 incompatible interfaces to work together. 
- Use this when the client expects a (target) interface.

Good thing:
You won't need to change your existing class or interface when using the Adapter pattern, but rather reuse
your existing class.

url : https://stackify.com/design-patterns-explained-adapter-pattern-with-code-examples/
