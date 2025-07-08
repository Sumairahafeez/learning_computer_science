#include<iostream>
using namespace std;
main()
{
    int n;
    cout<<"Enter the number of elements: ";
    cin>>n;
    int arr[n];
    int unique[n];
    cout<<"Enter "<<n<<" numbers, one per line:";
    for(int i = 0; i<n; i++)
    {   cin>>arr[i];
        arr[i]=unique[n];
    
        if(arr[i]==arr[n]){
            cout<<"Already Entered: "<<arr[i];
    
        }
        
      
        
    }
    cout<<"Unique numbers entered: "<<unique[n];
    
    
    
}

    
