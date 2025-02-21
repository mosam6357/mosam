a = int(input())
b = int(input())
aa={1,}
bb=[]
for i in range(b):
    c,d = map(int,input().split())
    bb.append([c,d])
    if(c==1 or d==1):
        aa.add(c)
        aa.add(d)
for q in range(a):
    for i in range(b):
        if(bb[i][0] in aa or bb[i][1] in aa):
            aa.add(bb[i][0])
            aa.add(bb[i][1])
print(len(aa)-1)