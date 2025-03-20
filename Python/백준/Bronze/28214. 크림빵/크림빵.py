a,b,c = map(int,input().split())
aa = list(map(int,input().split()))
cnt = 0
p = 0
for i in range(b,a*b+1,b):
    l = aa[p:i]
    if l.count(0)<c:
        cnt+=1
    p=i
print(cnt)