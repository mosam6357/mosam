a = int(input())
aa = []
final = []
for i in range(a):
    aa.append(input())
aa.sort()
for i in range(1,201):
    for j in range(a):
        if len(aa[j])==i:
            final.append(aa[j])
for i in range(a):
    print(final[i])