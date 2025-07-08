#include<iostream>
using namespace std;
void plant(string, int, int, int);
main()
    {   string seed;
        int water, fert, temp;
        cout<<"Enter seed type: ";
        cin>> seed;
        cout<<"Enter water units: ";
        cin>>water;
        cout<<"Enter fert units: ";
        cin>>fert;
        cout<<"Enter temp units: ";
        cin>>temp;
        plant (seed, water, fert, temp);

    }
void plant(string seed, int water, int fert, int temp)
{
    if(temp>=20 && temp <=30){
        for(int x = 1; x<=water; x++){
        for(int stem = 1; stem<=water; stem++)
        {
            cout<<"-";
        }
        for(int flower = 1; flower<=fert; flower++){
            cout<<seed;
        }
    }
}
else{
    for(int x = 1; x<= water; x++){
    for(int stem = 1; stem<=water; stem++)
    {
        cout<<"-";
    }
    
    }
    cout<<seed;
}
}
