import math

total = 0
while(total>=0):
    while(True):
        aa = input()
        if (aa=='0'):
            print(total)
            total=0
            break
        elif (aa=='#'):
            total=-1
            break
        a,b,c,d = aa.split()
        c = int(c)
        if (d=='F'):
            total+=c*2
        elif (d=='B'):
            total+=math.ceil(c*1.5)
        else:
            if (c<=500):
                total+=500
            else:
                total+=c