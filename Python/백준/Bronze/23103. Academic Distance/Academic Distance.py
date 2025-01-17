a = int(input())
sumd = 0; px = 0; py=0
for i in range(a):
    x,y = map(int,input().split())
    if i!=0:
        sumd+=abs(x-px)+abs(y-py)
    px = x
    py = y
print(sumd)