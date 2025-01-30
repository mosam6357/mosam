a = int(input())
aa = []
ck = 0
for i in range(a):
    aa.append(int(input()))
for i in range(1,aa[a-1]+1):
    if i not in aa:
        print(i)
        ck = 1
    if i==aa[a-1] and ck==0:
        print('good job')