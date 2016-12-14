// ConsoleApplication6.cpp : Defines the entry point for the console application.
//
//30) look at the following statements: char str[]"237.89"; double value;
// write a statement that converts the string in str to adouble and stores the result in value

#include "stdafx.h"
#include <cstring>



int main(int argc, _TCHAR* argv[])
{
	char str[] = "237.89";
	double value;

	value = atof(str[]);



	return 0;
}

