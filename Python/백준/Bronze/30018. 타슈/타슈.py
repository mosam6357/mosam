a = int(input())
aa = list(map(int,input().split()))
bb = list(map(int,input().split()))
total = 0
for i in range(a):
    total+=abs(aa[i]-bb[i])
print(total//2)