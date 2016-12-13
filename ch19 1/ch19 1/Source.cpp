#include <iostream>
#include <iomanip>
#include "Header.h"
using namespace std;

int main()
{
	Factorial factor;
	int a;
	int ans;

	cout << "What number do you wish to factor?" << endl;
	cin >> a;

	ans = factor.factorial(a);

	cout << "The answer is: " << ans << "." << endl;
}