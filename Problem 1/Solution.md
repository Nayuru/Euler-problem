# Problem Euler n°1
The subject is : 
*If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
Find the sum of all the multiples of 3 or 5 below 1000.*

### Global solution
This problem is an easy one if you know *very* basic maths, and *very* basic programmation.
You just need to know and understand what a multiple mean and implies.
After that, you just have to check every number from 1 to **n**, to see if they are multiples of **x** or **y**.
Here, we have these : 
* **n** = 1000
* **x** = 3
* **y** = 5

##### First solution
I went all the way through the most basic solution. Here, a simple *for loop*, and two modulo operations, one for *x* and one for *y*.

##### Second solution
I figured that all the multiples of 5 are either ending with 5, or with 0. So i wanted to try the speed of the algorithm when replacing
a modulo operation by two *built-in* functions of .Net framework. 
Eventually, this solution is slower, surely due to type conversion, and some conditionals in *built-in* functions.

