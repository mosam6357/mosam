a = int(input())
aa = []
for i in range(a):
    aa.append(input())
b = int(input())
for i in range(b):
    bb = list(map(int,input().split()))
    for j in range(bb[0],bb[1]+1):
        print(aa[j-1])