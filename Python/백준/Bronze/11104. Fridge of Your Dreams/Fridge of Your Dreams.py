a = int(input())
for i in range(a):
    ans = 0
    b = input()
    for j in range(len(b)):
        if(b[j]=='1'):
            ans+=2**(23-j)
    print(ans)