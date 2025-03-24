a,b = map(int,input().split())
total = a
while(a>=b):
    a//=b
    total+=a
print(total)