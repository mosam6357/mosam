a,b = map(int,input().split())
c = a*b/4840
if(c%5==0):
    print(int(c//5))
else:
    print(int(c//5)+1)