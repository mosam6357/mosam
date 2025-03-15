#include <iostream>
using namespace std;

int main(void){
    ios_base::sync_with_stdio(false);
    cin.tie(NULL);
    int t,a,n;
    cin >> t;
    for (int i=0;i<t;i++){
        cin >> a;
        int min = 1000001;
        int max = -1000001;
        for (int j=0;j<a;j++){
            cin >> n;
            max = max>n?max:n;
            min = min<n?min:n;
        }
        cout << min << " " << max << endl;
    }
    return 0;
}