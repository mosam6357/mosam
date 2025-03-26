a,b = map(int,input().split())
total = 1
for i in range(a,b+1):
    total*=(i*(i+1))//2
    total%=14579
print(total)