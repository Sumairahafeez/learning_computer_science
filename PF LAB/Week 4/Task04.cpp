#include <iostream>
using namespace std;
void add(int n1,int n2);
void sub(int n1,int n2);
void multiply(int n1,int n2);
void divide(int n1,int n2);
main(){
	int n1,n2;
	char op;
	cout<<"Enter 1st number: ";
	cin>>n1;
	cout<<"Enter 2nd number: ";
	cin>>n2;
	cout<<"Enter an operator (+, -, *, /): ";
	cin>>op;
	if (op=='+')
	{add(n1,n2);}
	if (op=='-')
	{sub(n1,n2);}
	if (op=='*')
	{multiply(n1,n2);}
	if (op=='/')
	{divide(n1,n2);}
}
void add(int n1,int n2)
{
	
	int sum;
	sum=n1+n2;
	cout<<"Addition: "<<sum;
	
}
void sub(int n1,int n2)
{
	int sub;
	sub=n1-n2;
	cout<<"Subtraction: "<<sub;	
}
void multiply(int n1,int n2)
{
	int mul;
	mul=n1*n2;
	cout<<"Multiplication: "<<mul;
}
void divide(int n1,int n2)
{
	int div;
	div=n1/n2;
	cout<<"Division: "<<div;
}