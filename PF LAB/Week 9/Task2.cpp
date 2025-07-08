#include<iostream>
using namespace std;
main()
{    string reverse;
    string word;
    cout<<"Enter a string: ";
    cin>>word;
      int count = 0;
    for(int idx=0; word[idx]!=0; idx++)
    {
        count++;
    }
    
    for(int idx=count; idx>=0; idx--)
    {
         reverse+=word[idx];
    }
    cout<<"Reversed String:"<<reverse;
}
