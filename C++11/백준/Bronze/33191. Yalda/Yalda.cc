#include <iostream>
using namespace std;

int main(){
    int m;
    cin >> m;
    int a[3];
    for (int i=0;i<3;i++){
        cin >> a[i];
    }
    if(a[0]<=m){
        cout << "Watermelon";
    }
    else if(a[1]<=m){
        cout << "Pomegranates";
    }
    else if(a[2]<=m){
        cout << "Nuts";
    }
    else{
        cout << "Nothing";
    }
}