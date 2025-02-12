a = int(input())
for i in range(a):
    aa = list(map(int,input().split()))
    n = aa.pop(0)
    avg = sum(aa)/n
    cnt = 0
    for j in aa:
        if j>avg:
            cnt+=1
    print(f"{(cnt/n)*100:.3f}%")