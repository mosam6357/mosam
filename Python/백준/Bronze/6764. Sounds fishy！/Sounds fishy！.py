aa=[]
for i in range(4):
    aa.append(int(input()))
if(max(aa)==min(aa)):
    print('Fish At Constant Depth')
elif(aa[0]<aa[1] and aa[1]<aa[2] and aa[2]<aa[3]):
    print('Fish Rising')
elif(aa[0]>aa[1] and aa[1]>aa[2] and aa[2]>aa[3]):
    print('Fish Diving')
else:
    print('No Fish')