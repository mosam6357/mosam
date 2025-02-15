#include <iostream>

using namespace std;

int main(void)
{
    int n;
    long long a=0,b=1,c;
    
    cin >> n;
    
    if (n==0 || n==1)
    {
        cout << n;
    }
    else
    {
        for (int i=0; i<n-1; i++)
        {
            c = a+b;
            a = b;
            b = c;
        }
        
        cout << c;
    }
}