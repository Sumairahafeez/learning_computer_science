#include<iostream>
using namespace std;
bool isSpecialArray(int arr[], int size);
main()
{
    int n;
    cout<<"Enter the size of the array: ";
    cin>>n;
    int arr[n];
    cout<<"Enter "<<n<<" elements of the array: "<<endl;
    for(int i = 0; i<n; i++)
    {
        cin>>arr[i];
        arr[n];
    }
    if(isSpecialArray(arr, n)){
        cout<<"The array is special";
    }
    else{
        cout<<"The array is not special";
    }
}
bool isSpecialArray(int arr[], int size)
{   bool isSpecial=false;
    for (int i = 0; i<size; i++){
    if(i%2==0){
        if(arr[i]%2==0)
        {
            isSpecial=true;
        }
    }
    else{
        if(arr[i]%2!=0){
            isSpecial=true;
        }
    }

}
return isSpecial;
}