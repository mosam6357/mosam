import sys

t = int(sys.stdin.readline())
a = 0
b = 0
for i in range(t):
    aa = list(map(int,sys.stdin.readline().split()))
    if aa[0]>aa[1]:
        a+=1
    elif aa[0]<aa[1]:
        b+=1
sys.stdout.write(str(a)+" "+str(b))