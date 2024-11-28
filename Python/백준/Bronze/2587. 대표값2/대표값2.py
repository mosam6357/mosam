aa = []
for i in range(5):
    aa.append(int(input()))
aa.sort()
print(sum(aa)//5)
print(aa[2])