#include<iostream>
using namespace std;
class KeyNode
{
    private:
        string Key;
        int Value;

}
class HashingTable
{   private:
        KeyNode Arr = [];
        int sizeOfHashTable;
        int KeysOccupied = 0;
    public:    
    HashingTable(size)
    {
        this.sizeofHashTable = size;
    }
    int GetHashTableSize()
    {
        return this.sizeOfHashTable;
    }
    int GetNumberOfKeys()
    {
        return KeysOccupied;
    }
    int GetHashFunction(string str)
    {   int previous = 0;
        for(int i=0; i<len(str); i++)
        {
            int j = str[i];
            previous += j;
        }
        return previous%128;
    }
    bool UpdateKey(Key,value)
    {
        for(int i=0; i<sizeOfHashTable; i++)
        {
            if(Arr[i]->Key == Key)
            {
                Arr[i] ->value +=1;
                return true;
            }
            else
            {
                Arr[Key] ->Key = Key;
                Arr[Key] ->value = value;
                return true;
            }
        }
        return false;
    }
    bool searchKey(Key)
    {
        for(int i =0; i<sizeOfHashTable; i++)
        {
            if(Arr[i]->Key = Key)
            {
                return Arr[i]->value;
            }
        }
    }
    bool ReHash()
    {
        if(KeysOccupied>sizeOfHashTable)
        {
            HashingTable newHash = new HashingTable(sizeOfHashTable);
            
        }
    }
}