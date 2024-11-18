a,b = map(int,input().split())
n,k = map(int,input().split())
cnt = 0
for i in range(a,b+1):
    if(i==n):
        cnt+=1
    elif(n-k<=i and n+k>=i):
        cnt+=1
if(cnt==0):
    print('IMPOSSIBLE')
else:
    print(cnt)