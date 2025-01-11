aa = []
for i in range(5):
    aa.append(sum(list(map(int,input().split()))))
print(aa.index(max(aa))+1,max(aa))