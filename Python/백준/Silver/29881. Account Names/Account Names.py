a = int(input())
aa = []
for i in range(a):
    aa.append(input().split())
for i in range(a):
    s = input().split()
    for i in range(a):
        if aa[i][0]==s[0]:
            print(aa[i][1],s[1])
            break