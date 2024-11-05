a,b = map(int,input().split())
c,d = map(int,input().split())
s=b-a
m=d-c
while(s!=m):
    if(s<m):
        s+=b
    elif(m<s):
        m+=d
print(s)