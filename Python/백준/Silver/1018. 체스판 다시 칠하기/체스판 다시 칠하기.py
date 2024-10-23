a,b = map(int,input().split())
aa=[input() for i in range(a)]
bb=[]
for i in range(a-7):
    for j in range(b-7):
        cnt=0
        for k in range(8):
            for l in range(8):
                if((i+j+k)%2==0):
                    if(aa[i+k][j+l]!='WBWBWBWB'[l]):
                        cnt+=1
                else:
                    if(aa[i+k][j+l]!='BWBWBWBW'[l]):
                        cnt+=1
        if cnt>32:
            bb.append(64-cnt)
        else:
            bb.append(cnt)
print(min(bb))