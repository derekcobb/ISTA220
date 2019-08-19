##Name: CSSBS Ch12

##Author: Derek Cobb

##Date: August 8 2019

---------------------------------------------------------------------
Read chapter 12, pages 267 - 288 in the C# Step by Step book.
1.2 Discussion Questions
Answer the discussion questions in writing.

--1. How does inheritance promote the principle of don't repeat yourself (DRY)?
(pg 268) Inheritance allows one to take qualities that are common to several different objects
and put them in a hierarching class that the different objects can access as sub-classes

--2. What is the syntax of a derived class that inherits from a base class?
(pg 268)
You declare that a class inherits from another class by using the following syntax:
class DerivedClass : BaseClass
{
...
}

--3. Do all user defined types (classes and structs) inherit from some base class? If so, what is it?
(pg 270)
Yes, The System.Object class is the root class of all classes.

--4. What happens if you do not have a default constructor in a base class when creating a derived class?
(pg 271/Class) If you don’t explicitly call a base-class constructor in a derived-class constructor, the compiler
attempts to silently insert a call to the base class’s default constructor before executing the code in the
derived-class constructor.

--5. Can you assign a variable of a derived class to another variable of its base class? Why or why not?
(pg 272) Yes, because the type of the base class is higher up in the inheritance hierarchy.

--6. Can you assign a variable of a derived class to another variable of a derived class of its base class?
Why or why not?
No, not accessible through the base class and they usually aren't of the same type. Really it depends but
generally the answer is no.

--7. Can you assign a variable of a base class to another variable of a derived class? Why or why not?
(pg 272) No, because the variable of the base class will not necessarily work for all derived classes.
For example a horse class and whale class my booth need to breathe but a horse moves by galloping while
a whale moves by swimming.

--8. Under what circumstances would you want to use the new keyword when defining a method in a
derived class?
(pgs 273 - 274) When your derived class has a method of the same name in the base class.

--9. What is a virtual method? Why would you want to define a virtual method?
(pg 275) A method that is intended to be overwritten. To serve as a placeholder in case you
want to provide your own version of the method.
(Class) Provide a different implementation.

--10. What does override do? Why does it do it?
(pg 275)
Overriding a method is a mechanism for
providing different implementations of the same method—the methods are all related 
because they are intended to perform the same task, but in a class-specific manner
To declare
another implementation of that method, as demonstrated here:

(Class) The difference between using "new" keyword and overriding is that overriding creates a completely new method.


--11. **How** do you define an extension type?
(pg 284)
Add a static public method to a static class. The first parameter must be of the type
being extended, preceded by the *this* keyword. For example:
static class Util
{
public static int Negate(this int i)
{
return -i;
}
}

--12. **Why** do you define an extension type?
VOID