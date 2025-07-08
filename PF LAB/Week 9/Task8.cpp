#include<iostream>
using namespace std;
void insertArrayInMiddle(int firstArray[], int firstArraySize, int secondArray[], int secondArraySize);
main()
{
    
    int n1;
    int  n2;
    cout<<"Enter the number of elements for the first array (must be 2): ";
    cin>>n1;
    cout<<"Enter "<<n1<<" elements for the firt array, one per line:"<<endl;
    int firstArray[n1];
    for(int i =0; i<n1; i++)
    {
        cin>>firstArray[i];
        firstArray[n1];
        
    }
    cout<<"Enter the number of elements for the second array: ";
    cin>>n2;
    cout<<"Enter "<<n2<<" elements for the second array, one per line: "<<endl;
    int secondArray[n2];
    for(int i =0 ; i<n2; i++)
    {
        cin>>secondArray[i];
        secondArray[n2];

    }
    cout<<insertArrayInMiddle(firstArray,n1,secondArray,n2);
}
void insertArrayInMiddle(int firstArray[], int firstArraySize, int secondArray[], int secondArraySize)
{  cout<<"Resulting array: ["<<firstArray[0]<<", ";
    for(int i = 0; i<secondArraySize; i++){
        cout<<secondArray[i]<<", ";
    }
    cout<<firstArray[1]<<"]";
      
    }