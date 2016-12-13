#include <iostream>
#include <iomanip>
using namespace std;

class Factorial 
{

private:
	int num;
public:
	int factorial(int);

};

int Factorial::factorial(int a)
{
	while(a != 0)
	{
		num = a * (a -1);
		a = a-1;
	}
	return num;
}