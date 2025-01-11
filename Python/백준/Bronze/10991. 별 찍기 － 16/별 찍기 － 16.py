a = int(input())
for i in range(a):
    print(' '*(a-i-1),end="")
    print('*',end="")
    for j in range(i):
        print(' *',end="")
    print('')