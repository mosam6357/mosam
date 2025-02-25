import sys

a,b = map(int,sys.stdin.readline().split())
aa = list(map(int,input().split()))
total = 0
add = []
for i in range(a):
    total+=aa[i]
    add.append(total)
m = -1000
for i in range(a-b+1):
    if i==0:
        n = add[i+b-1]
    else:
        n = add[i+b-1]-add[i-1]
    if n>m:
        m=n
sys.stdout.write(str(m))