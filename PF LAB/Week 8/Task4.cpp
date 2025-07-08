#include<iostream>
using namespace std;
int primeNumbers(int);
bool isPrime(int);
bool isEven(int);
main()
{
    int number;
    cout<<"Enter the number: ";
    cin>>number;
    cout<<primeNumbers(number);
}

int primeNumbers(int number)
{
    int count = 0;
    for(int x = 2; x<=number; x++)
    {
        if(isPrime(x)){
            count ++ ;
        }
    }
   return count;
   
}
bool isPrime(int n)
{
    if(n<=1){
        return false;

    }
    int x = 2,mod = 0;
    while(x<=n)
    {
         mod = n%x;
        if(mod == 0){
            return false;
        
        }
        x++;
    }
    return true;
}