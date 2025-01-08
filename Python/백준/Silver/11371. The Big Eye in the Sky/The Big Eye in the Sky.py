import math

angle = 90
while(True):
    x,y = map(int,input().split())
    if (x==0 and y==0):
        break
    if (x==0):
        print(90)
    else:
        aa = []
        n = y/x
        for i in range(90):
            aa.append(abs(math.tan(i*(math.pi/180))-n))
        print(aa.index(min(aa)))