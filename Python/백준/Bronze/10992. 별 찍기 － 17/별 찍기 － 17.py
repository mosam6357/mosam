a = int(input())
for i in range(a):
    if i==a-1:
        print('*'*(2*a-1))
    else:
        print(' '*(a-i-1),end="")
        print('*',end="")
        if i!=0:
            print(' '*(2*i-1),end="")
            print('*',end="")
        print('')