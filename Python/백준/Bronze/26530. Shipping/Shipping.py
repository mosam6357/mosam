a=int(input())
for i in range(a):
    sum=0
    b=int(input())
    for j in range(b):
        c=input().split()
        sum+=float(c[1])*float(c[2])
    print(f"${sum:.2f}")