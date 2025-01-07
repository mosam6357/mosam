a,b = map(int,input().split())
aa = []
cnt = 0
for i in range(a):
    aa.append(input())
for i in range(a):
    for j in range(b-1):
        if aa[i][j]==aa[i][j+1] and aa[i][j]=='.':
            cnt+=1
for i in range(b):
    for j in range(a-1):
        if aa[j][i]==aa[j+1][i] and aa[j][i]=='.':
            cnt+=1
print(cnt)