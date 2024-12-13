import sys

a,b = map(int,input().split())
aa={}
for i in range(a):
    bb = sys.stdin.readline().split()
    aa[bb[0]] = bb[1]
for j in range(b):
    sys.stdout.write(f"{aa[sys.stdin.readline().strip()]}\n")