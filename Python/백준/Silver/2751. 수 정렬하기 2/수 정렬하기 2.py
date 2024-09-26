import sys

a=int(sys.stdin.readline()); aa=[0 for i in range(a)]
for i in range(a):
    aa[i]=int(sys.stdin.readline())
aa.sort()
for i in range(a):
    sys.stdout.write(f"{aa[i]}\n")
