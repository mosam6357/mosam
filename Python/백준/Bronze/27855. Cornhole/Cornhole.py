aa = list(map(int,input().split()))
a = aa[0]*3+aa[1]
bb = list(map(int,input().split()))
b = bb[0]*3+bb[1]
if(a==b):
    print('NO SCORE')
elif(a>b):
    print(1,a-b)
else:
    print(2,b-a)