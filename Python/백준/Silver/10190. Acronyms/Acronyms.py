a = int(input())
for i in range(a):
    s1,n = input().split()
    print(s1)
    n = int(n)
    for j in range(n):
        bb = input().split()
        s2 = ''
        for k in bb:
            s2+=k[0]
        if s1==s2:
            print(*bb)