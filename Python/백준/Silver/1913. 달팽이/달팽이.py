a = int(input())
b = int(input())
c=a*a
d=0 #방향:아래쪽
x=0
y=0
q=0
w=0
aa = [[0 for j in range(a)] for i in range(a)]
while(c>0):
    if(c==b):
        q=y+1
        w=x+1
    aa[y][x] = c
    c-=1
    if(d==0):
        if(y!=a-1 and aa[y+1][x]==0):
            y+=1
        else:
            x+=1
            d=1
    elif(d==1):
        if(x!=a-1 and aa[y][x+1]==0):
            x+=1
        else:
            y-=1
            d=2
    elif(d==2):
        if(aa[y-1][x]==0):
            y-=1
        else:
            x-=1
            d=3
    else:
        if(aa[y][x-1]==0):
            x-=1
        else:
            y+=1
            d=0
for i in range(a):
    print(*aa[i])
print(q,w)