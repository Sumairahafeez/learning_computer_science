#include<iostream>
using namespace std;
double calculateTotalResistance(double resistance[], int size);
main()
{
    int n;
    cout<<"Enter the number of resistors in the series circuit: ";
    cin>>n;
    cout<<"Enter the resistance values (in ohms) of the "<<n<<" resistors, one per line:"<<endl;
    double arr[n];
    double sum = 0.00;
    for(int i = 0; i<n; i++)
    {
        cin>>arr[i];
        sum+=arr[i];
    }
    cout<<"The total resistance of the series circuit is "<<sum<<" ohms.";
}