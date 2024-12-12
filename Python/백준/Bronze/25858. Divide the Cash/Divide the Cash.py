a,b = map(int,input().split())
aa = []
for i in range(a):
    aa.append(int(input()))
for i in range(a):
    print(int(b*(aa[i]/sum(aa))))