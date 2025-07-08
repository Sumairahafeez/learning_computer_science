#include<iostream>
using namespace std;
bool canPayWithChange( double change, double totalDue);
main()
{
    double change[3],amount;
    double sum = 0.00;
    cout<<"Enter quarters: ";
    cin>>change[0];
    cout<<"Enter dimes: ";
    cin>>change[1];
    cout<<"Enter nickels: ";
    cin>>change[2];
    cout<<"Enter pennies: ";
    cin>>change[3];
    cout<<"Enter the total amount due: $";
    cin>>amount;
    sum=change[0]/0.25;
    sum=sum+(change[1]/0.1);
    sum=sum+(change[2]/0.05);
    sum=sum+(change[3]/0.01);
    cout<<"Can you pay the amount? ";
    if( canPayWithChange(sum,amount)){
        cout<<"Yes";
    }
    else{
        cout<<"No";
    }
}
bool canPayWithChange(double change, double totalDue)
{
    if(change>=totalDue){
        return true;
    }
    return false;
}