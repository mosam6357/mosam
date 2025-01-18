a = int(input())
for i in range(5):
    if i==0 or i==2 or i==4:
        for j in range(a):
            print("@"*a,end="")
            print(" "*(a*3),end="")
            print("@"*a)
    else:
        for j in range(a):
            print("@"*(a*5))