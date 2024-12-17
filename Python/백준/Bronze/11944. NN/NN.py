a,b = map(int,input().split())
c = len(str(a))
if(c*a>b):
    s = ''
    for i in range(a):
        s+=str(a)
    print(s[:b])
else:
    for i in range(a):
        print(a,end="")