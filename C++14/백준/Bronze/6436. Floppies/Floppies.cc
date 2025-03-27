#include <iostream>
#include <cmath>
using namespace std;

int main(void){
    double a;
    int i = 1;
    while(true){
        cin >> a;
        if (a==0){
            break;
        }
        cout << "File #" << i << endl;
        cout << "John needs " << ceil(a/2480000) <<" floppies." << "\n\n";
        i++;
    }
    return 0;
}