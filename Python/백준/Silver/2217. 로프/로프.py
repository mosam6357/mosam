import sys

a = int(sys.stdin.readline())
aa = []
bb = []
for i in range(a):
    aa.append(int(sys.stdin.readline()))
aa.sort()
for i in range(a):
    bb.append((a-i)*aa[i])
sys.stdout.write(f"{max(bb)}")