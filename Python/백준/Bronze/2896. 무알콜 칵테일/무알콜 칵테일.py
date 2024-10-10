aa = list(map(int,input().split()))
bb = list(map(int,input().split()))
cc=[]
for i in range(3):
    cc.append(aa[i]/bb[i])
d = cc.index(min(cc))
for i in range(3):
    if(i==d):
        print('0',end =" ")
    else:
        print(f'{aa[i]-bb[i]*min(cc)}',end=" ")