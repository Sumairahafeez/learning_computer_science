#include<iostream>
#include<climits>
using namespace std;
int findLargestNumber(int arr[], int size);
main()
{
    int n;
    cout<<"Enter the number of elements: ";
    cin>>n;
   
    cout<<"Enter "<<n<<" numbers, one per line: "<<endl;
     int arr[n]; 
     for(int i=0; i<n; i++)
    { cin>>arr[i];
    arr[n];}
    findLargestNumber(arr,n);
   
    cout<<"The largest number entered is: "<<findLargestNumber(arr,n);
}
int findLargestNumber(int arr[], int n)
{
    int maxNo=INT_MIN;
    for(int i=0; i<n; i++)
    { 
    if(arr[i]>maxNo)
    {
        maxNo=arr[i];
    }
    return maxNo;
}
}