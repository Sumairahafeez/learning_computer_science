#include <iostream>
using namespace std;
void Twenty(int num);
void convert(int a);
void ten(int number);
main(){
	cout<<"Enter a number (1-99): ";
	int number;
	cin>>number;
	
	ten(number);
	Twenty(number);
	
}
void ten(int number)
{	if(number==1)
	{cout<<"One";}
	if(number==2)
	{cout<<"Two";}
	if(number==3)
	{cout<<"Three";}
	if(number==4)
	{cout<<"Four";}
	if(number==5)
	{cout<<"Five";}
	if(number==6)
	{cout<<"Six";}
	if(number==7)
	{cout<<"seven";}
	if(number==8)
	{cout<<"Eight";}
	if(number==9)
	{cout<<"Nine";}
	if(number==10)	
	{cout<<"Ten";}
	if(number==11)
	{cout<<"Eleven";}
	if(number==12)
	{cout<<"Twelve";}
	if(number==13)
	{cout<<"Thirteen";}
	if(number==14)
	{cout<<"Fourteen";}
	if(number==15)
	{cout<<"Fifteen";}
	if(number==16)
	{cout<<"Sixteen";}
	if(number==17)
	{cout<<"Seventeen";}
	if(number==18)
	{cout<<"Eighteen";}
	if(number==19)
	{cout<<"Nineteen";}
}
void Twenty(int num)
{	
	int a=num%10;
	 num=num/10;
	if(num==2){
	cout<<"Twenty";
	convert(a);}
	if(num==3){
	cout<<"Thirty";
	convert(a);}
	if(num==4){
	cout<<"Forty";
	convert(a);}
	if(num==5){
	cout<<"Fifty";
	convert(a);}
	if(num==6){
	cout<<"Sixty";
	convert(a);}
	if(num==7){
	cout<<"Seven";
	convert(a);}
	if(num==8){
	cout<<"Eighty";
	convert(a);}
	if(num==9){
	cout<<"Ninety";
	convert(a);}
	
}
void convert(int a)
{	if(a==0){	
	cout<<"";}
	if(a==1){
	cout<<"One";}
	if(a==2){
	cout<<"Two";}
	if(a==3){
	cout<<"Three";}
	if(a==4){
	cout<<"Four";}
	if(a==5){
	cout<<"Five";}
	if(a==6){
	cout<<"Six";}
	if(a==7){
	cout<<"Seven";}
	if(a==8){
	cout<<"Eight";}
	if(a==9){
	cout<<"Nine";}
}
	
