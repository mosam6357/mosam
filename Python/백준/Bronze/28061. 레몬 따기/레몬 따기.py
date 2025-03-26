a = int(input())
aa = list(map(int,input().split()))
aa.reverse()
for i in range(a):
    aa[i]-=i+1
print(max(aa))