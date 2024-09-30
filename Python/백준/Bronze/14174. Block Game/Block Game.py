a=int(input())
aa=[0 for i in range(26)]
for i in range(a):
    b,c=input().split()
    for j in range(26):
        bb=[0 for i in range(2)]
        bb[0]=b.count(chr(97+j))
        bb[1]=c.count(chr(97+j))
        aa[j]+=max(bb)
for i in range(26):
    print(aa[i])