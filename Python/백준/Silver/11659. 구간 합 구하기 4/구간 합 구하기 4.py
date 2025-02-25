import sys

a,b = map(int,sys.stdin.readline().split())
aa = list(map(int,sys.stdin.readline().split()))
total = 0
add = []
for i in range(a):
    total+=aa[i]
    add.append(total)
for i in range(b):
    s,e = map(int,sys.stdin.readline().split())
    if s<2:
        sys.stdout.write(f"{add[e-1]}\n")
    else:
        sys.stdout.write(f"{add[e-1]-add[s-2]}\n")