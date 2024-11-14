a=int(input())
b,c = map(int,input().split())
b=b//2
if(b+c<a):
    print(b+c)
else:
    print(a)