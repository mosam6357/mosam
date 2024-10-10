a,b = map(int,input().split())
c,d = map(int,input().split())
e = int(input())
distance = abs(a-c)+abs(b-d)
if(distance>e):
    print('N')
else:
    if distance%2==e%2:
        print('Y')
    else:
        print('N')