#include<iostream>
using namespace std;
int frequencyChecker(int number, int digit);
main()
{
    int digit, num;
    cout<<"Enter a number: ";
    cin>>num;
    cout<<"Enter the digit to check: ";
    cin>>digit;
    cout<<"Frequency: "<<frequencyChecker(num,digit);
}
int frequencyChecker(int number, int digit)
{
    int count = 0;
    while(number!=0){
        int mod = number%10;
        
        if(mod == digit){
            count= count + 1;
        }
        number = number/10;
    }
    return count;
}