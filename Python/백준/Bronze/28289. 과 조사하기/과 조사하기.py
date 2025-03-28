a = int(input())
aa = [0,0,0,0]
for i in range(a):
    b,c,d = map(int,input().split())
    if b==1:
        aa[3]+=1
    elif c==1 or c==2:
        aa[0]+=1
    elif c==3:
        aa[1]+=1
    else:
        aa[2]+=1
print(*aa,sep='\n')