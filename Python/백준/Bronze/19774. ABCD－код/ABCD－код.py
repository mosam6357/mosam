t = int(input())
for i in range(t):
    n = int(input())
    a = n//1000
    b = (n%1000)//100
    c = (n%100)//10
    d = n%10
    p1 = (a*10+b)**2
    p2 = (c*10+d)**2
    if ((p1+p2)%7==1):
        print('YES')
    else:
        print('NO')