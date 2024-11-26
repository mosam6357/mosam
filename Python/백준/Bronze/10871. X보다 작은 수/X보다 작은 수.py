aa = input().split()
a=int(aa[0]); b=int(aa[1]); c=list(map(int, input().split()))
for i in range(a):
    if c[i]<b:
        print(c[i],end=" ")