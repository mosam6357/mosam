a=int(input()); cnt=0; same=0
c=a
while(same==0):
    c=((c%10)*10)+(c//10+c%10)%10
    cnt+=1
    if(a==c):
        same=1
print(cnt)
