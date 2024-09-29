while(True):
    a=input()
    length=1
    if(a=='0'):
        break
    else:
        for i in range(len(a)):
            if(a[i]=='1'):
                length+=3
            elif(a[i]=='0'):
                length+=5
            else:
                length+=4
        print(length)
