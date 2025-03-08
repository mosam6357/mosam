a,b,c,d = map(int,input().split())
total = 0
for i in range(b+1,a+1,b):
    total+=c*d
print(total)