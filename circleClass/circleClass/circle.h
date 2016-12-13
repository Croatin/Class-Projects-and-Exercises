#include <iostream>
#include <iomanip>
using namespace std;

class Circle
{

	private:
		double radius;
		double pi;
	public:
		void defaultConstructor();
		void userConstruct();
		void setRadius(double r);
		double getRadius();
		double getArea();
		double getDiameter();
		double getCircumference();
};

void Circle::defaultConstructor()
{
	radius = 0.0;
	pi = 3.1415926535897932384626433832795;
}
void Circle::userConstruct()
{
	double r;
	cout << "What would you like the radius of your circle to be?" << endl;
	cin >> r;
	while(r < 0)
	{
		cout << "You cannot have anything less than zero as your input." << endl << "Try again" << endl;
		cin >> r;
	}

	setRadius(r);
}
void Circle::setRadius(double r)
{
	radius = r;
}
double Circle::getRadius()
{
	return radius;
}
double Circle::getArea()
{
	double area;
	area = pi * radius * radius;
	return area;
}
double Circle::getDiameter()
{
	double diameter;
	diameter = radius * 2;
	return diameter;
}
double Circle::getCircumference()
{
	double circumference;
	circumference = 2 * pi * radius;
	return circumference;
}