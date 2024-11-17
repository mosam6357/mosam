a=int(input())
b=list(map(int,input().split()))
s=0
ans=0
for i in b:
    if(i==1):
        s+=1
    else:
        s-=1
    ans+=s
print(ans)