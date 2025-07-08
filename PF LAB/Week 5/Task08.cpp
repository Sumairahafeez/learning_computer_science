#include<iostream>
using namespace std;
int  odev(int num);
main()
{
    cout<<"Enter a five-digit number: ";
    int num;
    cin>>num;
	int res=odev(num);
	if(res%2==0){cout<<"Evenish";} 
    if(res%2!=0){cout<<"Oddish";}
	
}
  
int odev(int num)
{
    int a=num%10;
     num=num/10;
    int b=num%10;
     num=num/10;
    int c=num%10;
     num=num/10;
    int d=num%10;
    num=num/10;
    int result=a+b+c+d+num;
    return result;

}