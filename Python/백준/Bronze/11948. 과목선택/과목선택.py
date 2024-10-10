aa=[]; bb=[]
for i in range(4):
    aa.append(int(input()))
for i in range(2):
    bb.append(int(input()))
print(sum(aa)+sum(bb)-(min(aa)+min(bb)))