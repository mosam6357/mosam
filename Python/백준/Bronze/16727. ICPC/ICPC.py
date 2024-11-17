a,b = map(int,input().split())
aa = list(map(int,input().split()))
a+=aa[1]
b+=aa[0]
if(a==b):
    if(aa[0]==a-aa[1]):
        print('Penalty')
    elif(aa[1]<b-aa[0]):
        print('Esteghlal')
    else:
        print('Persepolis')
elif(a>b):
    print('Persepolis')
else:
    print('Esteghlal')