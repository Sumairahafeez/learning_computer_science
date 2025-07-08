#include <iostream>
using namespace std;
void result(int input);
main(){
	int marks;
	cout<<"Enter your score: ";
	cin>>marks;
	result(marks);


}
void result(int input)
{
	if (input>50)
	{cout<<"Pass";}
	if (input<=50)
	{cout<<"Fail";} 

}