import sys

a,b = map(int,sys.stdin.readline().split())
aa=set()
bb=set()
for i in range(a+b):
    s =sys.stdin.readline().strip()
    if(i<a):
        aa.add(s)
    else:
        bb.add(s)
cc = aa&bb
dd = list(cc)
dd.sort()
sys.stdout.write(f"{len(dd)}\n")
for i in dd:
    sys.stdout.write(f"{i}\n")