// ConsoleApplication5.cpp : Defines the entry point for the console application.
//
// 28) Assume input is a char array holding a c-string. Write code that counts the number of elements
// in the array that contain an alphabetic character



#include "stdafx.h"
#include <iostream>
#include <cstring>
#include <string>
using namespace std;

int main()
{
	string myStr = "Blanketty";

	 cout << "Input a sentance, i'll tell you how many characters are in it!" << endl;
	 //cin >> myStr;

	 cout << "Your string is " << myStr.size << " characters long." << endl;

	return 0;
}

// I get a weird error C3867