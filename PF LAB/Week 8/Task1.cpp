#include<iostream>
using namespace std;
bool doesBrickFit(int, int, int, int, int);
main()
{
    int a, b, c, h, w;
    cout<<"Enter height of brick: ";
    cin>>a;
    cout<<"Enter width of brick: ";
    cin>>b;
    cout<<"Enter depth of brick: ";
    cin>>c;
    cout<<"Enter height of hole: ";
    cin>>h;
    cout<<"Enter width of hole: ";
    cin>>w;

    cout<< doesBrickFit(a,b,c,h,w);
}
bool doesBrickFit(int a, int b, int c, int h, int w)
{
    int dimensionsOfBrick = 0;
    dimensionsOfBrick= a*b*c;
    int dimensionsOfHole = 2*(h*w);
    if(dimensionsOfBrick<=dimensionsOfHole){
        return true;
    }
    else{
        return false;
    }
}