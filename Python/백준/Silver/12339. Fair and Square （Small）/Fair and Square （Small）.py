a = int(input())
for i in range(a):
    x,y = map(int,input().split())
    n = 0
    for j in range(x,y+1):
        s = str(j)
        r = str(int(j**0.5))
        if (j**0.5==int(j**0.5)) and (s==s[::-1]) and (r==r[::-1]):
            n+=1
    print(f"Case #{i+1}: {n}")