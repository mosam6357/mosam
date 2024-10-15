a=int(input())
aa = [0 for i in range(5)]
bb = input().split()
for i in range(len(bb)):
    aa[i] = int(bb[i])
num = 0
if(aa[0]>aa[2]):
    num+=508*(aa[0]-aa[2])
else:
    num+=108*(aa[2]-aa[0])
if(aa[1]>aa[3]):
    num+=212*(aa[1]-aa[3])
else:
    num+=305*(aa[3]-aa[1])
num+=aa[4]*707
num*=4763
print(num)