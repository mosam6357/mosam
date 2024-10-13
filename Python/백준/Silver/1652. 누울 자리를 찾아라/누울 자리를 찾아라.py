a=int(input()); cnt1 = 0; cnt2 = 0; bb=[]
for i in range(a):
    bb.append(input())
    ck=0
    for j in range(a-1):
        if(bb[i][j]==bb[i][j+1] and bb[i][j]=='.' and ck==0):
            cnt1+=1
            ck=1
        elif(bb[i][j]=='X'):
            ck=0
for i in range(a):
    ck=0
    for j in range(a-1):
        if(bb[j][i]==bb[j+1][i] and bb[j][i]=='.' and ck==0):
            cnt2+=1
            ck=1
        elif(bb[j][i]=='X'):
            ck=0
print(cnt1,cnt2)