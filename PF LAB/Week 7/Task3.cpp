#include<iostream>
using namespace std;
int totalDigits(int number);
main()
{
    int num;
    cout<<"Enter a number: ";
    cin>>num;
    cout<<"Total number of digits: "<<totalDigits(num);
}
int totalDigits(int number)
{
int x=0;
if(number==0){
    x = 1;
}
else{
while(number>0)
{   
    int mod = number%10;
    number = number/10;
    x++;
    
    

}
}
return x;

}