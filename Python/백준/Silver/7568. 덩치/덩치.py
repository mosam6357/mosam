a = int(input())
aa = []
bb = []
g = 0
for i in range(a):
    b,c = map(int,input().split())
    aa.append([b,c])
for i in range(a):
    s = 1
    for j in range(a):
        if aa[i][0]<aa[j][0] and aa[i][1]<aa[j][1]:
            s+=1
    bb.append(s)
print(*bb)