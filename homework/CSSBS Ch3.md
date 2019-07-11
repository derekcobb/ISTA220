-- Name: CSSBS Homework Chapter 03
-- Author: Derek Cobb
-- Date: July 10, 2019

1. What is a method?

 (pg 61) A method is a named sequence of statements.
 
2. What does a return statement do?

 (pg 63) The return statement causes the method to finish, and control returns to the statement that called the method.
 
3. What is an expression bodied method?

 (pg 64) An expression-bodied method is an ordinary method that helps clean up code to make it easier to read by removing lots of extraneous {and} characters (a syntactic convenience)

4. What is the scope of a variable?

 (pg 71) The scope of a variable is the region of the program in which that variable is usable.
 
5. What is an overloaded method?

 (pg 72) An overloaded method is when there are two identifiers that have the same name and are declared in the same scope.
 
6. How do you call a method that requirements arguments?

 (pg 93) You specify the method name and provide any arguments between parentheses
 
7. How do you write a method, that is, specify the method definition, that requires a parameter list?

 (?) add a dot after the object, the method name and an argument in parentheses.

8. How do you specify a parameter as optional when defining a method?

  (pg 86) You specify that a paramenter is optional when you define a method by providing a default value for the parameter.
  
9. How do you pass an argument to a method as a named parameter?

 (pg 86-87) to pass an argument as a named parameter, you specif the name of the parameter, followed by a colon and the value to use.
 
10. How do you return values from a method? Can you return multiple values from a method, and if so, how?

 (pg 93) Write a return statement within the method. For example: return leftHandSide + rightHandSide;. You can return multipe values from a method by writing a return statement that returns a tuple. For example:
  return (division, remainder);
 
11. How does the compiler resolve an ambiguity between named arguments and optional parameters?

 (pg 88) The compiler resolves ambiguites between named arguments and optional parameters by running the version that most closely
  matches the method call. If neither version exactly matches the list of arguments then neither version is ran, since it is an unresolvable ambiguity.
  