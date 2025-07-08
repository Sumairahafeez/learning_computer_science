#include<iostream>
using namespace std;
string howBad(int num);
bool isEven(int);
bool isPrime(int);
main()
{
    int n;
    cout<<"Enter number: ";
    cin>>n;
    cout<<howBad(n);
}
string howBad(int num)
{
    int mod ;
    int sum = 0;
    while(mod!=0)
    {
        mod = num%2;
        if(mod == 1){
        sum=mod+sum;
        mod = sum;}
        num=num/2;

    
}

if(isEven(sum)){
  
    return "Evil";
}
else{
    return "Odious";
}
if(isPrime(sum)){
    return ", Pernicious";
}    




}
bool isEven(int sum)
{
    int d = sum%2;
    if(d == 0){
        return true;

    }
    return false;
    }
bool isPrime(int sum)
{   int mod;
    int x;
    while(x<sum)
    {
        mod = x%sum;
        if(mod == 0){
            return false;
        }
        
    }
    return true;
}

