import sys

a,b = map(int,sys.stdin.readline().split())
aa = list(map(int,sys.stdin.readline().split()))
n1 = 0
n2 = 0
count = 0
finish = 0
while(True):
    incount = 0
    for j in range(a-1):
        if aa[j]>aa[j+1]:
            n1 = aa[j+1]
            n2 = aa[j]
            aa[j+1] = n2
            aa[j] = n1
            count+=1
            incount+=1
            if count == b:
                break
    if count==b:
        break
    if incount==0:
        finish = 1
        break
if finish:
    sys.stdout.write("-1")
else:
    sys.stdout.write(f"{n1} {n2}")