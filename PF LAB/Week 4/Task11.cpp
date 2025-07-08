#include <iostream>
using namespace std;
void myName(string name);
main(){
while (true)
{	string name;
	cout<<"Enter your name: ";
	cin>>name;
	myName(name);}
}
void myName(string name)
{
	cout<<name<<endl;}