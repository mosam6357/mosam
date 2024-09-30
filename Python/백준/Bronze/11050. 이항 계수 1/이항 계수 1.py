a,b=map(int,input().split())
c=1; d=1; e=1
for i in range(a):
    c*=i+1
for i in range(a-b):
    d*=i+1
for i in range(b):
    e*=i+1
print(c//(d*e))