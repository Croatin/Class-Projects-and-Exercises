#include <iostream>
#include <string>
#include <iomanip>
using namespace std;

class Movie
{
private:
	string name;
	int showtime;
	string theater;
	double price;

public:
	void getMovie();
	void setMovie();
};

void Movie::setMovie()
{
	cout << "Movie name? " << endl;
	getline(cin, name);
	while(name == "")
	{
		cout << "The movie must have a name" << endl;
		getline(cin, name);
	}

	cout << "Theater name? " << endl;
	getline(cin, theater);
	while(name == "")
	{
		cout << "The theater must have a name" << endl;
		getline(cin, theater);
	}

	cout << "Show Time? In military time, please." << endl;
	cin >> showtime;
		
	while(showtime < 0)
	{
		cout << "Invalid input, try again." << endl;
		cin >> showtime;
	}
	

	cout << "Price? " << endl;
	cin >> price;

	while(price < 0)
	{
		cout << "I doubt they'll pay you to watch the movie, try again." << endl;
		cin >> price;
	}
}

void Movie::getMovie()
{
	cout << "Name: "<< name << "." << endl;
	cout << "Theater: " << theater << "." <<endl;
	cout << "ShowTime: " << showtime << "." << endl;
	cout << "Price: " << price << "." << endl;
}