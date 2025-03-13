a = int(input())
aa = []
for i in range(a):
    aa.append(input())
m = int(input())
if m==1:
    for i in aa:
        print(i)
elif m==2:
    for i in aa:
        print(i[::-1])
else:
    for i in range(a):
        print(aa[a-i-1])