#include<iostream>
using namespace std;
int totalWords(string);
main()
{    string reverse;
    string word;
    cout<<"Enter a string: ";
    cin>>word;
    int n = totalWords(word);
    for(int idx=n; idx>=0; idx--)
    {
         reverse+=word[idx];
    }
    cout<<"Reversed String:"<<reverse;
}
int totalWords(string word)
{   int count = 0;
    for(int idx=0; word[idx]!=0; idx++)
    {
        count++;
    }
    return count;
}