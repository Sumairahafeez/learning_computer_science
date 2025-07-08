#include<iostream>
using namespace std;
main()
{
    string statment;
    string result;
    cout<<"Enter a string: ";
    getline(cin, statment);
    char vowel[5]={'a', 'e', 'i', 'o', 'u' };
    for(int i = 0; statment[i]!='\0'; i++)
    {
        if(statment[i]=='a'|| statment[i]=='A' || statment[i]=='e' || statment[i]=='E' ||statment[i]=='i' || statment[i]=='I' || statment[i]=='o' || statment[i]=='O' || statment[i]=='u' || statment[i]=='U' )
        {   
            
            continue;
            
        }
        else{
            result+=statment[i];
        }
        
    }
    cout<<"String with vowels removed: "<<result;
}