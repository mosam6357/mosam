a = int(input())
for i in range(a):
    print(' '*(a-i-1),end="")
    print('*',end="")
    print(' '*(i*2-1),end="")
    if i!=0:
        print('*',end="")
    print("")