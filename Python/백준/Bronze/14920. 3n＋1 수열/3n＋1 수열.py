a = int(input())
c = 1
while(a!=1):
    if (a%2==0):
        a//=2
    else:
        a=a*3+1
    c+=1
print(c)