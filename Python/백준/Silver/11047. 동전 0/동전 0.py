import sys

a,b = map(int,sys.stdin.readline().split())
aa = []
c=0
cnt = 0
for i in range(a):
    aa.append(int(sys.stdin.readline().strip()))
aa.reverse()
while(b>0):
    for i in range(a):
        while(b>=aa[i]):
            c=b//aa[i]
            b-=aa[i]*c
            cnt+=c
sys.stdout.write(f"{cnt}")