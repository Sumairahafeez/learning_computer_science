#include<iostream>
#include<cmath>
using namespace std;
void determinant(float a, float b, float c);
main(){
	cout<<"Enter the value of a: ";
	float a;
	cin>>a;
	cout<<"Enter the value of b: ";
	float b;
	cin>>b;
	cout<<"Enter the value of c: ";
	float c;
	cin>>c;
	determinant(a,b,c);
}
void determinant(float a, float b, float c)
{	float det;
	det=((b*b)-(4*a*c));
	if(det>0){
	float rt1;
	rt1=(-b+sqrt(det))/(2*a);
	float rt2;
	rt2=(-b-sqrt(det))/(2*a);
	cout<<"Solutions: x = "<<rt1<<" and x = "<<rt2;}
	if(det<0){
	float rt1;
	rt1=(-b/2*a);
	float ra=sqrt(-det)/(2*a);
	
	cout<<"Complex Solutions: x = "<<rt1<<" + "<<ra<<"i and x = "<<rt1<<" - "<<ra<<"i";}
	if(det==0){
	float rt=-b/(2*a);
	cout<<"Solution: x = "<<rt;}
}
	

	