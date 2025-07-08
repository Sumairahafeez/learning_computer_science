#include<iostream>
using namespace std;
void printTable(int number);
main()
{
    int number;
    cout<<"Enter a number: ";
    cin>>number;
    printTable(number);
    
    
}
void printTable(int number)
{   int i,answer;
    for(i=1;i<=10;i++)
    {   answer=number*i;
        cout<<number<<" x "<<i<<" = "<<answer<<endl;    }
}