#include<iostream>
using namespace std;
void printReverseArray(int arr[],int n);
main()
{   int n;
    
    cout<<"Enter the number of elements: ";
    cin>>n;
   
    
     if(n<=0)
    {cout<<"Invalid input. Number of elements must be greater than 0.";}
    if(n>0){
    cout<<"Enter "<<n<<" numbers, one per line:"<<endl;}
     int num[n];
    for(int i = 0; i<n; i++)
    {
        cin>>num[i];
        
    }
    cout<<"Numbers in reverse order: ";
    printReverseArray(num, n);
}
void printReverseArray(int arr[],int n)
{   for(int x = n-1; x>=0; x--)
{
    cout<<arr[x]<<" ";
}

}