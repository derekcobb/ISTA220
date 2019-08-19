##Name: C#SBS ch13 Hmwk

##Author: Derek Cobb

##Date: August 12, 2019

Read chapter 13, pages 289 - 314 in the C# Step by Step book.
1.2 Discussion Questions
Answer the discussion questions in writing.

--1. What is an interface as the term is used in object-oriented programming?
(https://www.cs.utah.edu/~germain/PPS/Topics/interfaces.html)
An interface is a description of the actions that an object can do... 
for example when you flip a light switch, the light goes on, you don't care how, just that it does.
(Class) Creates a layer that decouples two entities; a component used to help you interact wiht another
block of code; it separates the what from the how.

--2. How do you define an interface?
(290)
Defining an interface is syntactically similar to defining a class, except that you use the interface
keyword instead of the class keyword. Within the interface, you declare methods exactly as in a class
or structure, except that you never specify an access modifier (public, private, or protected). Addition-
ally, the methods in an interface have no implementation; they are simply declarations, and all types
that implement the interface must provide their own implementations. Consequently, you replace the
method body with a semicolon. Here is an example:

(class) the Interface Keyword
interface IComparable
{
int CompareTo(object obj);
}

--3. Can an interface have variables, fields, or properties?
(pg 291)
An interface cannot contain any data; you cannot add fields (not even private ones) to an interface.

--4. How do you define a method in an interface?
(pg 291)?
interface ILandBound
{
int NumberOfLegs();
}

--5. Can you instantiate an object through an interface? Why or why not?
()
Yes


--6. Using the new keyword, can you declare a reference to an interface?
(292)
No. A class can inherit from another class and implement an interface at the same time. In this case,
C# does not distinguish between the base class and the interface by using specifi c keywords as,
for example, Java does. Instead, C# uses a positional notation. The base class is always named first,
followed by a comma, followed by the interface.
(Class) You can assign a reference to abilities
You cannot instantiate an object from an interface. You must do it from a concrete class.

--7. Can an object inherit(implement) from multiple interfaces? Can a class implement multiple interfaces? If so, how
can it do so?
(pg293)
No.
Yes. A class can have at most one base class, but it is allowed to implement an unlimited number of
interfaces.
class Horse : Mammal, ILandBound, IGrazable
{
...
}


--8. What does it mean to explicitly implement an interface?
(294)
disambiguate which method is part of which interface implementation

--9. What are the restrictions on interfaces?
(295-296)
You’re not allowed to defi ne any fi elds in an interface, not even static fi elds. A fi eld is an
implementation detail of a class or structure.
■ You’re not allowed to defi ne any constructors in an interface. A constructor is also considered to
be an implementation detail of a class or structure.
■ You’re not allowed to defi ne a destructor in an interface. A destructor contains the statements
used to destroy an object instance. (Destructors are described in Chapter 14, “Using garbage
collection and resource management.”)
You cannot specify an access modifi er for any method. All methods in an interface are implicitly public.
■ You cannot nest any types (such as enumerations, structures, classes, or interfaces) inside an
interface.
■ An interface is not allowed to inherit from a structure or a class, although an interface can
inherit from another interface. Structures and classes contain implementation; if an interface
were allowed to inherit from either, it would be inheriting some implementation.

--10. What is the difference between an abstract class and an interface?
(https://www.codeproject.com/Articles/11155/Abstract-Class-versus-Interface)
Feature                                            Interface                                                Abstract class

Multiple inheritance                    A class may inherit several interfaces.                 | A class may inherit only one abstract class.

Default implementation          An interface can't provide any code, just the signature.       | An abstract class can provide complete, default code and/or just the details that have to be overridden.

Access Modfiers	         An interface cannot have access modifiers for the subs, functions, properties etc everything is assumed as public	|An abstract class can contain access modifiers for the subs, functions, properties

Core VS Peripheral    	Interfaces are used to define the peripheral abilities of a class.			|An abstract class defines the core identity of a class and there it is used for objects of the same type.
						In other words both Human and Vehicle can inherit from a IMovable interface.



Homogeneity        If various implementations only share method signatures then it is better to use Interfaces.  |If various implementations are of the same kind and use common behaviour or status then abstract class is better to use.

Speed			Requires more time to find the actual method in the corresponding classes.				|Fast

Adding functionality (Versioning)  If we add a new method to an Interface then we have to track down all the implementations of the interface and define implementation for the new method.  |If we add a new method to an abstract class then we have the option of providing default implementation and therefore all the existing code might work properly.

Fields and Constants	No fields can be defined in interfaces										|An abstract class can have fields and constrants defined

The abstract has the implementation.

--11. What is an abstract method?
(pg306)
An abstract method is similar in principle to a vir-
tual method (covered in Chapter 12), except that it does not contain a method body

--12. What is a sealed class?
(306)
the sealed keyword to prevent a class from
being used as a base class if you decide that it should not be.
(Class) Cannot not inherit from something that has a sealed keyword


--13. What is a sealed method?
(307)
A keyword to declare that an individual method in an unsealed class is sealed.
This means that a derived class cannot override this method.