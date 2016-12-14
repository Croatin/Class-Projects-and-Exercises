#include <iostream>
#include <iomanip>
using namespace std;

class Factorial 
{

private:
	int num, ans;
public:
	int factorial(int);

};

int Factorial::factorial(int a)
{
	num = 1;
	while(a > 1)
	{
		cout << "Factoring: " << a << " x " << a - 1 << " = ";
		num = num * a;
		cout << num << "." << endl;
		a--;
	}
	return num;
}