#include <iostream>
#include <iomanip>
#include <string>
#include "calcInt.h"
using namespace std;

int main()
{
	Account accountMaker;
	double input;

	cout << "What is your balance, and i will calculate after a year of interest." << endl;
	cin >> input;

	accountMaker.calcInt(input);
}