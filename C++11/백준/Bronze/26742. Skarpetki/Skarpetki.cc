#include <stdio.h>
#include <string.h>
int main() {
    int b = 0;
    int w = 0;
    char a[1000001];
    scanf("%s", a);
    for (int i = 0; a[i] != NULL; i++) {
        if (a[i] == 'B') {
            b++;
        }
        else {
            w++;
        }
    }
    printf("%d", b / 2 + w / 2);
}