// Specification file for the MathStack class
#include <iostream>
#ifndef MATHSTACK_H
#define MATHSTACK_H
#include "IntStack.h"
using namespace std;

class MathStack : public IntStack
{
public:
   // Constructor
   MathStack(int s) : IntStack(s) {}
   
   // MathStack operations
   void add();
   void sub();

   void makeStacks();
   void mult();
   void div();
   void addAll();
   void multAll();
};
// Implementation file for the MathStack class

//***********************************************
// Member function add. add pops                *
// the first two values off the stack and       *
// adds them. The sum is pushed onto the stack. *
//***********************************************

void MathStack::add()
{
   int num, sum;

   // Pop the first two values off the stack.
   pop(sum);
   pop(num);

   // Add the two values, store in sum.
   sum += num;

   // Push sum back onto the stack.
   push(sum);
}

//***********************************************
// Member function sub. sub pops the            *
// first two values off the stack. The          *
// second value is subtracted from the          *
// first value. The difference is pushed        *
// onto the stack.                              *
//***********************************************

void MathStack::sub()
{
   int num, diff;

   // Pop the first two values off the stack.
   pop(diff);
   pop(num);

   // Subtract num from diff.
   diff -= num;

   // Push diff back onto the stack.
   push(diff);
}


void MathStack::mult()
{
  int num, diff, replace;

   // Pop the first two values off the stack.
   pop(diff);
   pop(num);

   // Subtract num from diff.
   replace = diff;
   diff *= num;

   // Push diff back onto the stack.
   push(num);
   push(replace);

   cout << "The product is " << diff << endl;
}

void MathStack::div()
{
	int num, div, replace;

   // Pop the first two values off the stack.
   pop(div);
   pop(num);

   // Subtract num from diff.
   replace = div;
   div /= num;

   // Push diff back onto the stack.
   push(num);
   push(replace);

   cout << "The division is " << div << endl;
}
void MathStack::addAll()
{
	
		int num, sum = 0;

	for(int i = 0; i < stackSize; i++)
	{	
		
		// Pop the first two values off the stack.
	   pop(num);

	   // Add the two values, store in sum.
	   sum *= num;

	   // Push sum back onto the stack.
	}
	
	push(sum);
	cout << "The Additioon is " << sum << endl;
}
void MathStack::multAll()
{
	int num, prod = 0;

	for(int i = 0; i < stackSize; i++)
	{	
		
		// Pop the first two values off the stack.
	   pop(num);

	   // Add the two values, store in sum.
	   prod *= num;

	   // Push sum back onto the stack.
	}
	
	push(prod);
	cout << "The product of all is " << prod << endl;
}

#endif
