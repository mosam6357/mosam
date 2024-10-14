a,b,c = map(int,input().split())
ans1 = a*b//c
ans2 = a*c//b
if(ans1>ans2):
    print(ans1)
else:
    print(ans2)