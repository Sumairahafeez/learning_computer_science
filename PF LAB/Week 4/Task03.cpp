#include<iostream>
using namespace std;
void howManyStickers(int sticks);
main(){
	int side;
	cout<<"Enter the side length of the Rubik's Cube: ";
	cin>>side;
	howManyStickers(side);
}
void howManyStickers(int sticks)
{	int stickers;
	stickers=6*(sticks*sticks);
	cout<<"Number of stickers needed: "<<stickers;







}