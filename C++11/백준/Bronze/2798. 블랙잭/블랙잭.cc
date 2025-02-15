#include <iostream>
#include <vector>

using namespace std;

int main(void)
{
    int count, maxsum, sum=0, max = 0;
    
    cin >> count >> maxsum;
    
    vector<int> card;
    
    for(int i=0; i<count; i++)
    {
        int a;
        
        cin >> a;
        card.push_back(a);
    
    }
    
    for(int i=0; i<count-2; i++)
    {
        for(int j=i+1; j<count-1; j++)
        {
            for(int z=j+1; z<count; z++)
            {
                sum = card[i] + card[j] + card[z];
                
                if (sum<=maxsum)
                {
                    max = max>sum?max:sum; 
                }
            }
        }
    }
    
    cout <<  max;
    
    return 0;
}