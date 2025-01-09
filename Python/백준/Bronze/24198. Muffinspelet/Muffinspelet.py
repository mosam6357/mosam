a = int(input())
s1 = 0
s2 = 0
i=0
while(a>0):
    if (i%2==0):
        if(a%2==1):
            s2+=a//2+1
            a-=a//2+1
        else:
            s2 += a//2
            a-=a//2
    else:
        if(a%2==1):
            s1+=a//2+1
            a-=a//2+1
        else:
            s1 += a//2
            a-=a//2
    i+=1
print(s1,s2)