a = int(input())
for i in range(2*a-1):
    print('*'*(a-abs(a-(i+1))))