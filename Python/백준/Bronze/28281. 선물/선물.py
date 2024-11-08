a,b = map(int,input().split())
aa = list(map(int,input().split()))
bb=[]
for i in range(len(aa)-1):
    bb.append(aa[i]+aa[i+1])
print(min(bb)*b)