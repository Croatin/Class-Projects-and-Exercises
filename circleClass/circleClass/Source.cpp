#include <iostream>
#include <iomanip>
#include "Circle.h"
using namespace std;


int main()
{
	Circle circleMaker;

	circleMaker.defaultConstructor();
	circleMaker.userConstruct();
	
	cout << "The radius of your circle is " << circleMaker.getRadius() << "." << endl;
	cout << "The Area of your circle is " << circleMaker.getArea() << "." << endl;
	cout << "The Diameter of your circle is " << circleMaker.getDiameter() << "." << endl;
	cout << "The Circumference of your circle is " << circleMaker.getCircumference() << "." << endl;

}