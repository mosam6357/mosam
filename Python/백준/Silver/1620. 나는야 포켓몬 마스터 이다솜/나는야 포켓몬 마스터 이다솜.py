import sys

a,b = map(int,sys.stdin.readline().split())
aa = {}
for i in range(a):
    aa[sys.stdin.readline().strip()] = i+1
bb = {v:k for k,v in aa.items()}
for i in range(b):
    c = sys.stdin.readline().strip()
    if(c.isdigit()):
        sys.stdout.write(f"{bb[int(c)]}\n")
    else:
        sys.stdout.write(f"{aa[c]}\n")