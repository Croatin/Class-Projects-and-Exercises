#include <iostream>
#include <iomanip>
#include "MathStack.h"
#include "IntStack.h"
using namespace std;

int main()
{
	int num;
	MathStack stack(3);

	for(int i = 0; i < 3; i++)
	{
		cout << "Input your #" << i+1 << " number" << endl;
		cin >> num;

		stack.push(num);

	}

	stack.mult();

	stack.div();

	stack.addAll();

	stack.multAll();
}
