##Name: CSSBS Ch11
##Author: Derek Cobb
##Date: August 7 2019

---------------------------------------------------------------------
Read chapter 11, pages 255 - 266 in the C# Step by Step book.
1.2 Discussion Questions
Answer the discussion questions in writing.

--1. How do you define a method that takes an arbitrary number of arguments?
(pg 256)A method that takes a variable number of arguments is a *variadic method* aka (parameter array)

--2. How do you call a method that takes an arbitrary number of arguments?
(pg 257) You call a (parameter)variadic array method by using the *params* keyword as an array
parameter modifier when you define the method parameters.

--3. Why can't you use an array to pass an arbitrary number of arguments to a method?
(pg 258) The params keyword cannot be used with multidimensional arrays. Because an array is a static
object

--4. How many parameters can a method have?
(pg 259) You can only have one params array per method. Takes multipe

--5. Do parameter arguments have to have the same type?
(pg 259) No, you can use a parameters array of type *object* to declare a method that accepts any
number of *object* arguments, allowing the arguments passed in to be of any type.
[It depends]

--6. What is the difference between a method that takes a parameter argument and one that takes optional
arguments?
(pg 263)
A method that takes optional parameters still has a fixed parameter list, and you cannot pass
an arbitrary list of arguments
A method that uses a parameter array effectively has a completely arbitrary list of parameters,
and none of them has a default value

--7. How do you define a method that takes different (and arbitrary) types of arguments?
(pg 266)
(Mr. Carter) Define as a parameter array and use an object type.