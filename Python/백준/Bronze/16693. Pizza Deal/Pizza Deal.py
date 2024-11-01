import math

a,b = map(int,input().split())
c,d = map(int,input().split())
c1 = a/b
c2 = (c*c*math.pi)/d
if(c1>c2):
    print('Slice of pizza')
else:
    print('Whole pizza')