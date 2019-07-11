-- Name: CSSBS Homework Chapter 04

-- Author: Derek Cobb

-- Date: July 11, 2018

1. What are all possible values of a Boolean expression?

 (pg 95) True or false
 
2. List eight Boolean operators.

 (pg 96) 1. == (equal to), != (Not equal to), < (less than), <= (less than or equal to), > (greater than), >= (greater than or equal to), && (logical AND), || (logical OR)
 
3. What is the general concept of short circuiting? This question has a short and simple answer and you do not need to have a detailed response.

 (pg 98) Evaluate the design simpler boolean expression for the left side of a conditional logical operator to limit evaluating and boost performance
 
4. What are the difference in how short circuiting works for && and ||?

 (pg 98) The leftside must evaluate to 'false' for the evaluation of the entire expression to be 'false with && (condiitonal and) while the leftside must evaluate to 'true' for the evaluation of the entire expression to be 'true'.
 
5. Look at the list of operators. What operator has the highest precedence? Which has the lowest?

 (pg 98-99) The ()(precedence override) have the highest precedence. The = has lowest precedence.
 
6. In an if or else construction using multiple lines of code, what effect does the use of curly braces have?

 (pg 101) The curly braces prevent the C# compiler from associating only the first statement with the if statement. The else keyword will not get associated with the if statement and a syntax error with be reported.
 
7. In a switch statement, what happens if you omit break?

 (pg 109) If the break statement is omitted then the switch statement will never stop.
 
8. (Not in book) What is a recursive method? Using a language you know (such as English), write a
recursive method that adds up the integers in a list of integers. The input to the method is a list of
integers and the output is a scalar value representing a sum.

 (me/internet/class) I recursive method is a method that calls itself.
 
	Grocery shopping example: You are given a list of items to buy. You go down each aisle to obtain an item on the list, the item is grabbed and put in the cart. The list is checked and then you move the next item
	and the process is done again. This continues until the list is complete and all of the items have been added to the cart.