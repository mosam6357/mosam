a,b = map(int,input().split())
aa = []
for i in range(a):
    s = input()
    cnt = 0
    for j in range(b):
        if s[j]=='1':
            if j==0 or s[j-1]=='0':
                cnt+=1
    aa.append(cnt)
print(max(aa),aa.count(max(aa)))