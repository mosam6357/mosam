q=int(input())
for i in range(q):
    a,b,c,d = map(int,input().split())
    if(a*b>c*d):
        print('TelecomParisTech')
    elif(a*b==c*d):
        print('Tie')
    else:
        print('Eurecom')