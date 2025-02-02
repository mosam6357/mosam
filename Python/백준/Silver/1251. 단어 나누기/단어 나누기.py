a = input()
aa = []
for i in range(1,len(a)-1):
    for j in range(i+1,len(a)):
        s1 = a[:i][::-1]
        s2 = a[i:j][::-1]
        s3 = a[j:][::-1]
        aa.append(s1+s2+s3)
aa.sort()
print(aa[0])