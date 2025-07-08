#include<iostream>
using namespace std;
bool isAlreadyPresent(int arr[], int size, int number);
main()
{   
    int n;
    cout<<"Enter the number of elements: ";
    cin>>n;
    int arr[n];
    int unique[n];
    int num = 0;
    int x=0;
    cout<<"Enter "<<n<<" numbers, one per line:"<<endl;
    for(int i = 0; i<n; i++)
    {   cin>>arr[i];
    num=arr[i];
        
        if(isAlreadyPresent(arr,n,arr[i])){
            cout<<"Already Entered: "<<arr[i]<<endl;
           continue;
        }
        
         unique[x]=num;
         x++;
         

        
    }cout<<"Unique numbers entered: ";
    for(int j = 0; j<x; j++)
    {
        cout<<unique[j]<<" ";
    }
    
}
bool isAlreadyPresent(int arr[], int n, int number)
{
    bool isFound=false;
    for(int i = 0; i<n; i++){
    if(arr[number]==arr[i])
    {
        isFound=true;
    break;}
    return isFound;
}
}