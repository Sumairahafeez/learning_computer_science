#include<iostream>
using namespace std;
main(){
	string name;
	cout<<"Enter the name of the cricket team: ";
	cin>>name;

	int wins;
	cout<<"Enter the number of wins: ";
	cin>>wins;

	int draws;
	cout<<"Enter the number of draws: ";
	cin>>draws;

	int losses;
	cout<<"Enter the number of losses: ";
	cin>>losses;

	int result;
	result=(wins*3)+(draws*1);

	cout<<name<<" has obtained "<<result<<" points in the Asia Cup Tournament.";








}