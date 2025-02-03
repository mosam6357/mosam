a = int(input())
for i in range(2*a-1):
    print(' '*(abs(a-(i+1))),end="")
    print('*'*(a-abs(a-(i+1))))