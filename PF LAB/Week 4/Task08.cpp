#include <iostream>
using namespace std;
void calculatePayableAmount(float amount,string day);
main()
{
	string day;
	cout<<"Enter the day of purchase: ";
	cin>>day;
	float price;
	cout<<"Enter the total purchase amount: $";
	cin>>price;
	if (day=="Sunday")
	{calculatePayableAmount(price,day);}
	if (day!="Sunday")
	{cout<<"Payable Amount: $"<<price;}
}
void calculatePayableAmount(float amount,string day)
{
	int discount;
	discount=amount*0.1;
	int remAm;
	remAm=amount-discount;
	cout<<"Payable Amount: $"<<remAm;
}