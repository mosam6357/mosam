a = int(input())
aa = []
pb = 0
for i in range(a):
    b,c = map(int,input().split())
    if(c==1 and i!=0):
        aa.append(b-pb)
    if c==1:
        pb = b
print(max(aa))