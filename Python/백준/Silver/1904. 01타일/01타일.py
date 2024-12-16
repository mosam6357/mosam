a=int(input())
aa=[0,1,2,3,5]
if(a<5):
    print(aa[a])
else:
    b=aa[3]
    c=aa[4]
    ans = 0
    for i in range(a-4):
        ans = (b+c)%15746
        b=c
        c=ans
    print(ans)