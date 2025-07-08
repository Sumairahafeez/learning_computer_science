#include<iostream>
using namespace std;
void generateFibonacci(int length);
main()
{   int length;
    cout<<"Enter the length of the Fibonacci series: ";
    cin>>length;
    generateFibonacci(length);
}
void generateFibonacci(int length)
{   int n1 = 0;
    int n2 = 1;
    int next;
    for(int i = 0; i<length; i++)
    {
        cout<<n1;
       if(i!=length-1)
       {
        cout<<", ";
       }
       next = n1+n2;
       n1=n2;
       n2 = next; 
       }
}