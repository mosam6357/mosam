a=int(input()); sum=0; i=0
while(True):
    i+=1
    b=str(i)
    if("666" in b):
        sum+=1
        if(sum==a):
            print(i)
            break