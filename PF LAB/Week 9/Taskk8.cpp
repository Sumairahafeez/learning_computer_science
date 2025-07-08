#include<iostream>
using namespace std;
main(){
    int n1;
    int  n2;
    cout<<"Enter the number of elements for the first array (must be 2): ";
    cin>>n1;
    int firstArray[n1];
    for(int i =0; i<n1; i++)
    {
        cin>>firstArray[i];
      
    }
    cout<<"Enter the number of elements for the second array: ";
    cin>>n2;
    int secondArray[n2];
    for(int i =0 ; i<n2; i++)
    {
        cin>>secondArray[i];
        
    }
    cout<<"Resulting array: ["<<firstArray[0]<<", ";
    for(int i = 0; i<n2; i++)
    {
        cout<<secondArray[i]<<", ";
    }
    cout<<firstArray[1]<<"]";
    return 0;  
}