#include<iostream>
using namespace std;
void IsSymmetrical(int num);
main(){	cout<<"Enter a three-digit number: ";
	int num;
	cin>>num;
	
	IsSymmetrical(num);
	
}
void IsSymmetrical(int num)
{	int a;
	a=num%10;
	num=num/10;
	num=num/10;
	if(num==a){
	cout<<"The number is symmetrical.";}
	if(num!=a){
	cout<<"The number is not symmetrical.";}
	
}

	
	
	
	
	


