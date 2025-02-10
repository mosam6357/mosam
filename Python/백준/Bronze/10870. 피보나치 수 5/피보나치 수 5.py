a = int(input())
if a<=1:
    print(a)
else:
    n1=0
    n2=1
    ans = 0
    for i in range(a-1):
        ans = n1+n2
        n1 = n2
        n2 = ans
    print(ans)