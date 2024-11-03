#include <iostream>
using namespace std;
int main(){
    int a,b;
    cin >> a >> b;
    if(b<=a){
        cout << "Congratulations, you are within the speed limit!";
    }
    else{
        int cost;
        if(b-a<=20){
            cost = 100;
        }
        else if(b-a<=30){
            cost = 270;
        }
        else{
            cost = 500;
        }
        cout << "You are speeding and your fine is $"<< cost <<'.';
    }
}