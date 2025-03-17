import sys

n,c,t = map(int,sys.stdin.readline().split())
for i in range(t):
    a,b = map(int,sys.stdin.readline().split())
    if c==a:
        c=b
    elif c==b:
        c=a
sys.stdout.write(str(c))