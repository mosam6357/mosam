a=int(input())
aa={}
for i in range(a):
    b=input()
    if b not in aa:
        aa[b]=1
    else:
        aa[b]+=1
bb = dict(sorted(aa.items()))
print(max(bb,key=aa.get))