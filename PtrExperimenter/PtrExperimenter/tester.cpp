#include <iostream>
#include <string>
#include <iomanip>
using namespace std;

int main()
{
	int *ptr;
	int thing1 = 5;

	ptr = &thing1;

	cout << "&Ptr = " << &ptr << endl << "*ptr = " << *ptr << endl << "Ptr = " << ptr << endl;
}