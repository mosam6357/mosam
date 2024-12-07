import math

i=1
while(True):
    a,b,c = map(float,input().split())
    if(b==0):
        break
    mile = a*math.pi*b/63360
    mph = (3600/c)*mile
    print(f"Trip #{i}: {mile:.2f} {mph:.2f}")
    i+=1