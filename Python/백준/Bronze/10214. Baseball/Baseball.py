t = int(input())
for i in range(t):
    a=0; b=0
    for j in range(9):
        aa = list(map(int,input().split()))
        a+=aa[0]
        b+=aa[1]
    if a>b:
        print('Yonsei')
    elif a<b:
        print('Korea')
    else:
        print('Draw')