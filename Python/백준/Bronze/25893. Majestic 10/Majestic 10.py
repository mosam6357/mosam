q=int(input())
for i in range(q):
    cnt=0
    aa = list(map(int,input().split()))
    print(*aa)
    for i in range(3):
        if aa[i]>=10:
            cnt+=1
    if(cnt==0):
        print('zilch\n')
    elif(cnt==1):
        print('double\n')
    elif(cnt==2):
        print('double-double\n')
    else:
        print('triple-double\n')