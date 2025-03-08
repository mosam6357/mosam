a = int(input())
n = int(input())
b = float(input())
for i in range(n):
    f1,f2 = map(float,input().split())
    if (a/f1+a/f2)<b:
        print('HOPE')
        break
    if i==n-1:
        print('DOOMED')