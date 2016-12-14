#include <iostream>
#include <string>
#include "inverse.h"
using namespace std;

int main()
{
	Pallendrome pallen;
	string against, check;

	cout << "What would you like me to check if it's a pallendrome?" << endl;
	cin >> check;

	against = pallen.pallCheck(check, 0, check.size()+1);
	cout << "The reverse is: " << against << endl;

	if(check == against)
		cout << "you have a pallendrome" << endl;
	else
		cout << "You do not have a pallendrome" << endl;

}
