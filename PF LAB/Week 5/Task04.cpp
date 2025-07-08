#include<iostream>
#include<cmath>
using namespace std;

main(){
	cout<<"Enter the distance from the base of the tree (in feet): ";
	float distance;
	cin>>distance;
	cout<<"Enter the angle of elevation (in degrees): ";
	float angle;
	cin>>angle;
	float rad;
	rad=angle/57.2958;
	tan(rad);
	float ans;
	ans=tan(rad)*distance;

	cout<<"The height of the tree is: "<<ans<<" feet";




}