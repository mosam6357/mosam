a=int(input())
print("Gnomes:")
for i in range(a):
    b,c,d =map(int,input().split())
    if((b<c and c<d) or (b>c and c>d)):
        print('Ordered')
    else:
        print('Unordered')