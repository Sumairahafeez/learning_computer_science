#include<iostream>
using namespace std;
main(){
	float population;
	cout<<"Enter the current world population: ";
	cin>>population;

	int BirthRate;
	cout<<"Enter the monthly birth rate (number of births per month): ";
	cin>>BirthRate;

	float yearsInDecade;
	yearsInDecade=30;
	int monthsInYear;
	monthsInYear=12;
	float totalMonths;
	totalMonths=monthsInYear*yearsInDecade;
	float output=population+(totalMonths*BirthRate);
	cout<<"The population in three decades will be: " <<output;









}