import sys

t = int(sys.stdin.readline())
x = 0 #xor 연산용
add = 0 #총합 집계용
for i in range(t):
    s = sys.stdin.readline()
    if s[0] == '1':
        n = int(s.split()[1])
        add+=n
        x^= n
    elif s[0] == '2':
        n = int(s.split()[1])
        add-=n
        x^=n
    elif s[0] == '3':
        sys.stdout.write(str(add)+'\n')
    else:
        sys.stdout.write(str(x)+'\n')