#include <iostream>
using namespace std;
void eligibility(int input);
main(){
	int age;
	cout<<"Enter your age: ";
	cin>>age;
	eligibility(age);


}
void eligibility(int input)
{
	if (input>=18)
	{cout<<"You are eligible to vote.";}
	if (input<18)
	{cout<<"You are not eligible to vote.";} 

}