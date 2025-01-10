a = int(input())
for i in range(5):
    if (i==0 or i==1 or i==3):
        for j in range(a):
            print('@'*a,end="")
            print(' '*3*a,end="")
            print('@'*a)
    else:
        for j in range(a):
            print('@@@@@'*a)