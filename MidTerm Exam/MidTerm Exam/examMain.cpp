#include <iostream>
#include <iomanip>
#include "movie.h"
using namespace std;

int main()
{
	Movie movieMaker1, movieMaker2;
	
	cout << "Please input information about your first movie." << endl;
	movieMaker1.setMovie();
	cout << "Please input information about your second movie." << endl;
	movieMaker2.setMovie();

	cout << "Here is your information about your first movie." << endl;
	movieMaker1.getMovie();
	cout << "Here is your information about your second movie." << endl;
	movieMaker2.getMovie();
}
