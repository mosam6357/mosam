a,b = map(int,input().split())
aa = [0 for i in range(10)]
for i in range(a,b+1):
    s = str(i)
    for i in s:
        aa[int(i)]+=1
print(*aa)