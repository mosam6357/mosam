a,b,c = map(int,input().split())
jump = c-b
if a%jump==0:
    print(a//jump)
else:
    print(a//jump+1)