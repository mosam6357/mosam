a = list(map(int,input().split()))
cnt=0
for i in a:
    if(max(a)-i<=1000 and max(a)!=i):
        cnt+=1
print(cnt)