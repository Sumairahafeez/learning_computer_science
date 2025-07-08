#include<iostream>
using namespace std;
float perimeter(char shape, float length);
main(){
    float length;
    char shape;
    cout<<"Enter the shape (s for square, c for circle, t for triangle, h for hexagon): ";
    cin>>shape;
    cout<<"Enter the value: ";
    cin>>length;
    cout<<"The perimeter is: "<<perimeter(shape,length);

}
float perimeter(char shape, float length)
{   float result;
    if(shape== 's'){
        result= length*4;
    }
     if(shape== 'c'){
        result= length*6.28;
    }
     if(shape== 't'){
        result= length*3.0;
    }
     if(shape== 'h'){
        result= length*6.0;
    }
    return result;
}