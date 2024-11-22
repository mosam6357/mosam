l,k,p = 0,0,0
for i in range(3):
    a=input()
    if(a[0]=='l'):
        l=1
    elif(a[0]=='k'):
        k=1
    elif(a[0]=='p'):
        p=1
if(l*k*p==1):
    print('GLOBAL')
else:
    print('PONIX')