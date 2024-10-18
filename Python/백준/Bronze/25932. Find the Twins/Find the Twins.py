a=int(input())
for i in range(a):
    aa=list(map(int,input().split()))
    print(*aa)
    if(17 in aa and 18 in aa):
        print('both\n')
    elif(18 in aa):
        print('mack\n')
    elif(17 in aa):
        print('zack\n')
    else:
        print('none\n')