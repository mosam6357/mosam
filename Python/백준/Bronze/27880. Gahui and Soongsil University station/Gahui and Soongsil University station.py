cm = 0
for i in range(4):
    aa = input().split()
    h = int(aa[1])
    if(aa[0]=='Es'):
        cm+=h*21
    else:
        cm+=h*17
print(cm)