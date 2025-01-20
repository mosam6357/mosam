a = int(input())
for i in range(3):
    for j in range(a):
        if i==0:
            print('G'*a,end="")
            print('.'*(a*3))
        elif i==1:
            print('.'*a,end="")
            print('I'*a,end="")
            print('.'*a,end="")
            print('T'*a)
        else:
            print('.'*(a*2),end="")
            print('S'*a,end="")
            print('.'*a)