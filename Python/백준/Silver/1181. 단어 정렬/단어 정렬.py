import sys
a=int(sys.stdin.readline()); aa = set()
for i in range(a):
    aa.add(sys.stdin.readline())
bb = list(aa)
bb.sort()
bb.sort(key=len)
for i in range(len(aa)):
    sys.stdout.write(f"{bb[i]}")
