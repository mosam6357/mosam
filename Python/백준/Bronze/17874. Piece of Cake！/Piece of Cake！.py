n,a,b = map(int,input().split())
if(a<n-a):
    a = n-a
if(b<n-b):
    b = n-b
print(a*b*4)