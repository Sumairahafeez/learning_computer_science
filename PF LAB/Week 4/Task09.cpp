#include <iostream>
using namespace std;
void calculateFuel(float distance);
main()
{
	float distance;
	cout<<"Enter the distance: ";
	cin>>distance;
	if(distance<10)
	{cout<<"Fuel needed: 100";}
	if(distance>=10)
	{calculateFuel(distance);}
	
}
void calculateFuel(float distance)
{
	int fuel;
	fuel=distance*10;
	cout<<"Fuel needed: "<<fuel;
}