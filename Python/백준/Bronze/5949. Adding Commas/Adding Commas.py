a=input()
a=a[::-1]
if(len(a)%4==0):
    b = len(a)//4
else:
    b = len(a)//4+1
for i in range(b):
    a = a[:4*(i+1)-1]+','+a[4*(i+1)-1:]
a = a[::-1]
if(a[0]==','):
    print(a[1:])
else:
    print(a)