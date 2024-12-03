a = int(input())
for i in range(a):
    aa = list(map(int,input().split()))
    del aa[0]
    b=0;c=0 #홀수합, 짝수합 저장하는 변수
    for j in aa:
        if j%2==1:
            b+=j
        else:
            c+=j
    if(b==c):
        print('TIE')
    elif(b>c):
        print('ODD')
    else:
        print('EVEN')