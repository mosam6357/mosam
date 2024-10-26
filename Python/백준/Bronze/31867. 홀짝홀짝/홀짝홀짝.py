q=int(input())
a=input()
cnt=0
for i in a:
    b = int(i)
    if(b%2==1):
        cnt+=1
    else:
        cnt-=1
if(cnt==0):
    print(-1)
elif(cnt>0):
    print(1)
else:
    print(0)