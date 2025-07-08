#include<iostream>
using namespace std;
void jazzifyChords(string chords[], int numChords);
main()
{
    int n;
    cout<<"Enter the number of chords: ";
    cin>>n;
    string chords[n];
    cout<<"Enter "<<n<<" chords, one per line: "<<endl;
    for(int i = 0; i<n; i++)
    {
        cin>>chords[i];
        chords[n];
    }
    jazzifyChords(chords,n);
}
void jazzifyChords(string chords[], int size)
{   cout<<"Jazzified chords: [";
    for(int i = 0; i<size; i++){
    
   
if(chords[i].back()!='7'){
  cout<<chords[i]<<"7";
    
}
else{
    cout<<chords[i];
}
if(i!=size-1){
    cout<<", ";
}

    

}
cout<<"]";
}
