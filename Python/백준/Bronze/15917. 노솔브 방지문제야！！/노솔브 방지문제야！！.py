import sys

t = int(sys.stdin.readline())
for i in range(t):
    n = 1
    a = int(sys.stdin.readline())
    while(a>n):
        n*=2
    if (a==n):
        sys.stdout.write('1\n')
    else:
        sys.stdout.write('0\n')