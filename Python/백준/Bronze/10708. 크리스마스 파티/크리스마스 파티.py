a = int(input())
b = int(input())
aa = list(map(int,input().split()))
s = [0 for i in range(a)]
for i in range(b):
    bb = list(map(int,input().split()))
    for j in range(a):
        if bb[j]==aa[i]:
            s[j]+=1
            if j==aa[i]-1:
                s[j]+=a-bb.count(aa[i])
for i in range(a):
    print(s[i])