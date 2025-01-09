import sys
a = int(sys.stdin.readline())
aa = list(map(int,sys.stdin.readline().split()))
aa.sort()
bb = []
s = 0
for i in range(a):
    s+=aa[i]*i-sum(bb)
    bb.append(aa[i])
sys.stdout.write(str(s*2))