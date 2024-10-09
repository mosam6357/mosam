a=int(input())
if(a==0):
    print('divide by zero')
else:
    aa=list(map(int,input().split()))
    if(sum(aa)/len(aa)==0):
        print('divide by zero')
    else:
        print('1.00')