a=int(input())
for i in range(a):
    aa=list(map(int,input().split()))
    print(*aa)
    if(aa[0]==1):
        print(aa[1])
    else:
        print(aa[1]+(aa[0]-1)*(aa[1]-2))