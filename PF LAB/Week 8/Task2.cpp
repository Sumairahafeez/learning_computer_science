#include<iostream>
using namespace std;
int calculateDamage(string, string, int, int);
main()
{
    int attackPower, defencePower;
    string type, opponentsType;
    cout<<"Your Type: ";
    cin>>type;
    cout<<"Opponents Type: ";
    cin>>opponentsType;
    cout<<"Your attack power: ";
    cin>>attackPower;
    cout<<"The opponents defence power: ";
    cin>>defencePower;
    cout<< calculateDamage(type, opponentsType, attackPower, defencePower);
}
int calculateDamage( string type, string opponentsType, int attackPower, int defencePower)
{   int damage, effectiveness;
    if(type == "fire"){
        if(opponentsType == "water"){
           return  damage = 50*(attackPower/defencePower)*0.5;
        }
        if(opponentsType == "grass"){
            effectiveness = 2;
            return  damage = 50*(attackPower/defencePower)*2;
        }
        if(opponentsType == "electric"){
            effectiveness = 1;
            return  damage = 50*(attackPower/defencePower)*1;
        }
    }
    
    if(type == "water"){
        if(opponentsType == "fire"){
            effectiveness = 2;
             return  damage = 50*(attackPower/defencePower)*2;
        }
        if(opponentsType == "grass"){
            effectiveness = 0.5;
             return  damage = 50*(attackPower/defencePower)*0.5;
        }
        if(opponentsType == "electric"){
            effectiveness = 0.5;
             return  damage = 50*(attackPower/defencePower)*0.5;
        }

    } 
    if(type == "grass"){
        if(opponentsType == "fire"){
            effectiveness = 0.5;
             return  damage = 50*(attackPower/defencePower)*0.5;
        }
        if(opponentsType == "water"){
            effectiveness = 2;
             return  damage = 50*(attackPower/defencePower)*2;
        }
        if(opponentsType == "electric"){
            effectiveness = 1;
             return  damage = 50*(attackPower/defencePower)*1;
        }
    } 
    if(type == "electric"){
        if(opponentsType == "fire"){
            effectiveness = 1;
             return  damage = 50*(attackPower/defencePower)*1;
        }
        if(opponentsType == "water"){
            effectiveness = 0.5;
             return  damage = 50*(attackPower/defencePower)*0.5;
        }
        if(opponentsType == "grass"){
            effectiveness = 1;
             return  damage = 50*(attackPower/defencePower)*1;
        }
    }
    
}
    
