p = 0
aa=[]
for i in range(11):
    aa.append(list(map(int,input().split())))
aa.sort(key=lambda x:x[0])
time = 0
for i in range(11):
    time+=aa[i][0]
    p+=time+aa[i][1]*20
print(p)