import sys

a = int(sys.stdin.readline())
if a==0:
    print(0)
else:
    p = int(a*0.15)
    if ((a*0.15)%1>=0.5):
        p +=1
    aa = []
    for i in range(a):
        aa.append(int(sys.stdin.readline()))
    aa.sort()
    s = 0
    for i in range(a):
        if i>=p and i<=a-p-1:
            s+=aa[i]
    avg = s/(a-2*p)
    if avg%1>=0.5:
        sys.stdout.write(f"{int(avg)+1}")
    else:
        sys.stdout.write(f"{int(avg)}")