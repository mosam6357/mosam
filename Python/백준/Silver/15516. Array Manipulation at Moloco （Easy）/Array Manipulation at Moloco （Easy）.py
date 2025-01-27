a = int(input())
aa = []
for i in range(a):
    b = int(input())
    aa.append(b)
    cnt = 0
    for j in range(i):
        if b>aa[j]:
            cnt+=1
    print(cnt)