a = int(input())
for i in range(5):
    for j in range(a):
        if (i==0 or i==4):
            print('@'*(a*5))
        else:
            print('@'*a,end="")
            print(' '*(a*3),end="")
            print('@'*a)