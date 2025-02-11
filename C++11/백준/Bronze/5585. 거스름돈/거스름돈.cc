#include <iostream>
#include <string>
using namespace std;

int main(){
    int a;
    cin >> a;
    a = 1000-a;
    cout << a/500+(a%500)/100+(a%100)/50+(a%50)/10+(a%10)/5+a%5;
    return 0;
}