#include <iostream>
using namespace std;
main(){
	cout << "Enter the student's name: ";
	string name;
	cin >> name;

	cout << "Enter matriculation marks (out of 1100): ";
	float matricMarks;
	cin >> matricMarks;

	cout << "Enter intermediate marks (out of 550): ";
	float interMarks;
	cin >> interMarks;

	cout << "Enter Ecat marks (out of 400): ";
	float Emarks;
	cin >> Emarks;

	float agg;
	agg=(Emarks/400*0.5)+(matricMarks/1100*0.1)+(interMarks/550*0.4);

	float aggregate;
	aggregate=agg*100;
	cout << "Aggregate score for " << name << " in UET is: "<< aggregate <<"%";










}