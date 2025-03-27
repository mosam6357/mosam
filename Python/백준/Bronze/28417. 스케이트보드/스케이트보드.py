import sys

a = int(sys.stdin.readline())
score = []
for i in range(a):
    aa = list(map(int,sys.stdin.readline().split()))
    bb = aa[:2]
    cc = aa[2:]
    total = max(bb)+max(cc)
    cc.remove(max(cc))
    total+=max(cc)
    score.append(total)
sys.stdout.write(str(max(score)))