#include <iostream>
#include <fstream>
#include <iomanip>
#include <string>
#include <cctype>
using namespace std;

void arrayToFile(string name, int *pointerArray, int sizeOfArray)
{
	fstream dataFile;

	if(dataFile.fail())
        cout << "File doesnt exist!" << endl;

	cout << "Storing data!" << endl;
	dataFile.open(name, ios::out | ios::binary);
	dataFile >> *pointerArray;
	
//	dataFile.write(reinterpret_cast<string> (pointerArray), sizeOfArray);

	cout << "This is what i'm storing" << *pointerArray << endl;

	dataFile.close();
}

void fileToArray(string name, int *pointerArray, int sizeOfArray)
{
	fstream dataFile;

	if(dataFile.fail())
        cout << "File doesnt exist!" << endl;

	cout << "Opening Data!" << endl;
	dataFile.open(name, ios::in | ios::binary);

	cout << "This is what i have stored for you. " << dataFile << *pointerArray << endl;

int main ()
{
	//the array must be numbers. We're translating a number array

	int number[5];
	int *pointer[5];
	string file = "binaryConverter.txt";

	for(int i = 0; i < 5; i++)
	{
		cout << "Give me a number." << endl;
		cin >> number[i];
	}

	arrayToFile(file, *pointer, 5);

	fileToArray(file, *pointer, 5);



}
