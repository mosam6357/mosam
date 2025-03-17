t = int(input())
for i in range(t):
    a,b = map(int,input().split())
    while(a%b!=0):
        a+=1
    print(a//b)