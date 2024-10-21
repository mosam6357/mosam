a,b=map(int,input().split())
c=1; sqrt=1
aa=[]
while(a>b*c-1):
    c*=b
    sqrt+=1
for i in range(sqrt):
    if(c==0):
        c=1
    aa.append(a//c)
    a-=(a//c)*c
    c=c//b
for i in range(len(aa)):
    if(aa[i]>9):
        print(chr(aa[i]+55),end="")
    else:
        print(aa[i],end="")