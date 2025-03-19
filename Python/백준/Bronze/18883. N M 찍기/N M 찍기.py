a,b = map(int,input().split())
for i in range(a):
    aa = [i*b+j+1 for j in range(b)]
    print(*aa)