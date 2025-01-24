a = int(input())
aa = list(map(int,input().split()))
bb = [] #이익의 리스트
for i in range(a):
    for j in range(i,a):
        bb.append(aa[j]-aa[i])
print(max(bb))