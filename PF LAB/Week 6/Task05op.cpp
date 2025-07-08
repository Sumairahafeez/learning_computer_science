#include<iostream>
using namespace std;
float discount(string day, string month, int amount);
main(){
    float amount;
    string day, month;
    cout<<"Enter Purchase Day: ";
    cin>>day;
    cout<<"Enter Purchase Month: ";
    cin>>month;
    cout<<"Enter Purchase Amount: ";
    cin>>amount;
    cout<<"Payable Amount after discount: "<<discount(day,month,amount);
}
float discount(string day, string month, int amount)
{   float payable = amount;
    if(day == "Sunday" && (month == "October" || month == "March" || month == "August")){
        return ( amount - (amount*0.1));
    }
    
    
}