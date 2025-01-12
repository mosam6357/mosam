import sys

a = int(sys.stdin.readline())
aa = {}
for i in range(10000):
    aa[i+1]=0
for i in range(a):
    aa[int(sys.stdin.readline())]+=1
for i in range(10000):
    for j in range(aa[i+1]):
        sys.stdout.write(str(i+1)+'\n')