#include <iostream>
using namespace std;
int main(){
    int q,a,b,c;
    int max =  0;
    cin >> q;
    for(int i =0; i<q; i++){
        cin >> a>> b>> c;
        int score = a*(b+c);
        if(a==b+c){
            score *= 2;
        }
        max = max>score?max:score;
    }
    cout << max;
}