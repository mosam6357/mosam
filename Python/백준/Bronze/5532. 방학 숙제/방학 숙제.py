a=int(input()); aa=[]
b=int(input()); c=int(input())
d=int(input()); e=int(input())
if(b%d==0):
    aa.append(b//d)
else:
    aa.append(b//d+1)
if(c%e==0):
    aa.append(c//e)
else:
    aa.append(c//e+1)
print(a-max(aa))