a=int(input())
aa = [1,3,4]
if(a<=4):
    if(a in aa):
        print('SK')
    else:
        print('CY')
else:
    if(a%7==0 or a%7==2):
        print('CY')
    else:
        print('SK')
