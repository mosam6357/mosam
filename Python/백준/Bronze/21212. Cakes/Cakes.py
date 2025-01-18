a = int(input())
aa = []
for i in range(a):
    bb = list(map(int,input().split()))
    aa.append(bb[1]//bb[0])
print(min(aa))