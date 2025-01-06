q = int(input())
for i in range(q):
    n,a,b = map(int,input().split())
    aa = list(map(int,input().split()))
    if aa[0]==a and aa[n-1]==b:
        print('BOTH')
    if aa[0]!=a and aa[n-1]!=b:
        print('OKAY')
    if aa[0]==a and aa[n-1]!=b:
        print('EASY')
    if aa[0]!=a and aa[n-1]==b:
        print('HARD')