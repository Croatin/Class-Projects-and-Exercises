#include <iostream>
#include <string>
using namespace std;

void function(string, int, int);

int main()
{
	string mystr = "hello";
	cout << mystr << endl;
	function(mystr, 0, mystr.size());
	return(0);
}

void function(string str, int pos, int size)
{
	if(pos < size)
	{
		function(str, pos+1, size);
		cout << str[pos];
	}
}