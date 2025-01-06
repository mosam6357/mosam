a,b,q = map(int,input().split())
cnt = 0
c = str(q)
for i in range(b-a+1):
    s = str(a+i)
    for j in s:
        if j==c:
            cnt+=1
print(cnt)