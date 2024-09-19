a,b=map(int,input().split()); s=512; i=0; e=[0 for i in range(10)]; sum=0
while(a!=0 or b!=0):
    if(a>=s):
        a-=s
        e[i]+=1
    if(b>=s):
        b-=s
        e[i]+=1
    s=s//2
    i+=1
s=512
for i in range(10):
    if(e[i]==1):
        sum+=s
    s=s//2
print(sum)