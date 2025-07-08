#include<iostream>
using namespace std;
void inchesToFeet(float inches);
main(){
	float measurement;
	cout<<"Enter the measurement in inches: ";
	cin>>measurement;
	inchesToFeet(measurement);
}
void inchesToFeet(float inches)
{	float equi;
	equi=inches/12;
	cout<<"Equivalent in feet: "<<equi;







}