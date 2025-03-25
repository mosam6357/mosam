a = int(input())
aa = list(map(int,input().split()))
total = aa[0]
prev = aa[0]
for i in range(1,a):
    if aa[i]!=aa[i-1]+1:
        prev = aa[i]
        total+=prev
print(total)