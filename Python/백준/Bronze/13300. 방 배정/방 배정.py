a,b = map(int,input().split())
p = [0 for i in range(12)]
cnt = 0
for i in range(a):
    s,g = map(int,input().split())
    p[s*6+g-1]+=1
for i in p:
    if i%b==0:
        cnt+=i//b
    else:
        cnt+=i//b+1
print(cnt)