import math

angle = 90
while(True):
    a,b = map(int,input().split())
    if (a==0 and b==0):
        break
    if(a==0):
        print(90)
    else:
        print(round(180*math.atan(b/a)/math.pi))