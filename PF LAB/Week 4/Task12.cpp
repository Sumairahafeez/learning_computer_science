#include <iostream>
using namespace std;
void calculatePayableAmount(float amount,string day);
void calculateOther(float amount,string day);
main()
{	while(true)
	{string day;
	cout<<"Enter the day of purchase: ";
	cin>>day;
	float price;
	cout<<"Enter the total purchase amount: $";
	cin>>price;
	if (day=="Sunday")
	{calculatePayableAmount(price,day);}
	if (day!="Sunday")
	{calculateOther(price,day);}}
}
void calculatePayableAmount(float amount,string day)
{
	int discount;
	discount=amount*0.1;
	int remAm;
	remAm=amount-discount;
	cout<<"Payable Amount: $"<<remAm<<endl;
}
void calculateOther(float amount,string day)
{
	int discount;
	discount=amount*0.5;
	int rem2=amount-discount;
	cout<<"Payable amount: $"<<rem2<<endl;
}