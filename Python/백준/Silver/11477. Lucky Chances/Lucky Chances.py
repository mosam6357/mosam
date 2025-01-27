a,b = map(int,input().split())
aa = []
for i in range(a):
    aa.append(list(map(int,input().split())))
cnt = 0
for i in range(a):
    for j in range(b):
        if j==0:
            cnt+=1
        else:
            if max(aa[i][:j])<aa[i][j]:
                cnt+=1
        if j==b-1:
            cnt+=1
        else:
            if max(aa[i][j+1:])<aa[i][j]:
                cnt+=1
        bb = []
        for k in range(a):
            bb.append(aa[k][j])
        if i==0:
            cnt+=1
        else:
            if max(bb[:i])<aa[i][j]:
                cnt+=1
        if i==a-1:
            cnt+=1
        else:
            if max(bb[i+1:])<aa[i][j]:
                cnt+=1
print(cnt)