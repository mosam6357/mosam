import sys

while(True):
    a,b,c,d = map(int,sys.stdin.readline().split())
    if (a==b and b==c and c==d and a==0):
        break
    cnt = 0
    while(a!=b or b!=c or c!=d or d!=a):
        aa = [abs(a-b),abs(b-c),abs(c-d),abs(d-a)]
        a = aa[0]
        b = aa[1]
        c = aa[2]
        d = aa[3]
        cnt+=1
    sys.stdout.write(str(cnt)+'\n')