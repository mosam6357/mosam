n = int(input())
if (n<=1):
    print(n)
else:
    n1 = 0
    n2 = 1
    ans = 0
    for i in range(n-1):
        ans = n1+n2
        n1 = n2
        n2 = ans
    print(ans)