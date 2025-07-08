#include<iostream>
using namespace std;
float findGreatest(int num1, int num2, int num3);
main(){
    int n1,n2,n3;
    cout<<"Enter the first number: ";
    cin>>n1;
    cout<<"Enter the second number: ";
    cin>>n2;
    cout<<"Enter the third number: ";
    cin>>n3;
    cout<<"The greatest number among "<<n1<<", "<<n2<<", and "<<n3<<" is: "<<findGreatest(n1,n2,n3);
}
float findGreatest(int num1, int  num2, int num3)
{
    if(num1>=num2){
        if(num1>=num3 ){
            return num1;
        }
    }
    if(num2>=num1){
        if(num2>=num3){
            return num2;
        }
    }
    if(num3>=num1){
        if(num3>=num2){
            return num3;
        }
    }
}