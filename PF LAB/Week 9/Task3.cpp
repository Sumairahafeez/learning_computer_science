#include<iostream>
using namespace std;
int asciiCheck(int);
main()
{
    string a;
    cout<<"Enter a String: ";
    getline(cin,a);
    string result;
    for(int i = 0; a[i]!='\0'; i++)
    {
        char character = a[i];
        int ascii=character;
        
                
        ascii=asciiCheck(ascii)+1;
        
        character=ascii;
        result+=character;
    }
    cout<<"Shifted String: "<<result;
}
int asciiCheck(int ascii)
{
    if(ascii==90){
            ascii=64;
        }
        if(ascii==122){
            ascii=96;
        }
        if(ascii==32){
            ascii=31;
        }
        else{
            ascii=ascii;
        }
        return ascii;
}