import sys

a = int(sys.stdin.readline())
aa = list(map(int,sys.stdin.readline().split()))
s = list(set(sorted(aa)))
dic = {}
for j in range(len(s)):
    dic[s[j]] = j
for i in aa:
    sys.stdout.write(f"{dic[i]} ")