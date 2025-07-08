#include<iostream>
#include<climits>
using namespace std;
main()
{
    int n;
    cout<<"Enter the number of elements: ";
    cin>>n;
    int arr[n];
    cout<<"Enter "<<n<<" numbers, one per line: "<<endl;
     int maxNo=INT_MIN;
    for(int i=0; i<n; i++)
    { cin>>arr[i];
    if(arr[i]>maxNo)
    {
        maxNo=arr[i];
    }
    
}
    cout<<"The largest number entered is: "<<maxNo;
}
