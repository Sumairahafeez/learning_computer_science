#include <iostream>
#include <string>
using namespace std;
bool greaterNumber(int num1, int num2);
main(){
    int num1,num2;
    cout<<"Enter the first number: ";
    cin>>num1;
    cout<<"Enter the second number: ";
    cin>>num2;
    cout<<greaterNumber(num1,num2);
    return 0;
}
bool greaterNumber(int num1, int num2){
    int result;
    if(num1>num2){
        result = true;
    }
    else{
        result = false;
    }
    return result;

}
