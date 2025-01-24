a,b,c = map(int,input().split())
aa = []
cnt = 0
for i in range(a):
    aa.append(input())
for x in range(b):
    for i in range(a-c+1):
        s = aa[i][x]
        for j in range(c-1):
            s+=aa[i+j+1][x]
        if '#' not in s:
            cnt+=1
for y in range(a):
    for i in range(b-c+1):
        s = aa[y][i]
        for j in range(c-1):
            s+=aa[y][i+j+1]
        if '#' not in s:
            cnt+=1
print(cnt)