#include <iostream>
using namespace std;
bool parityAnalysis(int num);
main(){
    int num;
    cout<<"Enter a 3-digit number: ";
    cin>>num;
    cout<<parityAnalysis(num);
}
bool parityAnalysis(int num)
{
    int a,b,c;
    a=num%10;
    c=num/10;
    b=num%10;
    c=num/10;
    if(num%2==0 && (a+b+c)%2==0 ){
        return true;
    }
    else{
        return false;
    }
}