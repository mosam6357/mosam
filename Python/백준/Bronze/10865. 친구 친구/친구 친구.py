import sys

a,b = map(int,sys.stdin.readline().split())
aa = [0 for i in range(a)]
for i in range(b):
    c,d = map(int,sys.stdin.readline().split())
    aa[c-1]+=1
    aa[d-1]+=1
for i in range(a):
    sys.stdout.write(f'{aa[i]}\n')