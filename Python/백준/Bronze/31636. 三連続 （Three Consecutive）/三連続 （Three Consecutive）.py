a=int(input())
if a<3:
    print('No')
else:
    ck=0
    b=input()
    for i in range(a-2):
        if(b[i:i+3]=='ooo'):
            print('Yes')
            ck=1
            break
    if(ck==0):
        print('No')