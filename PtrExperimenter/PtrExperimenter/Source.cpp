#include <iostream>
#include <string>
#include <iomanip>
using namespace std;

int main()
{
	int *ptr;

	*ptr = 5;

	cout << "Ptr = " << ptr << "*ptr = " << *ptr << endl;
}