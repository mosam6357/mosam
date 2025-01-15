a = int(input())
aa = dict()
for i in range(a):
    s = input().split()
    if (s[2]=='Russia'):
        aa[int(s[0])]=s[1]
print(aa[max(aa.keys())])