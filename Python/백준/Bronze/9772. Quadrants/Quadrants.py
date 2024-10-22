while(True):
    a,b = map(float,input().split())
    if(a==0 or b==0):
        print('AXIS')
        if(a+b==0):
            break
    elif(a>0 and b>0):
        print('Q1')
    elif(a<0 and b>0):
        print('Q2')
    elif(a<0 and b<0):
        print('Q3')
    else:
        print('Q4')