import sys

a,b,c = map(int,sys.stdin.readline().split())
t = a*3600+b*60+c
q = int(sys.stdin.readline())
for i in range(q):
    aa = sys.stdin.readline().rstrip()
    if (aa=='3'):
        while(t<0):
            t+=86400
        while(t>86400):
            t-=86400
        sys.stdout.write(f"{t//3600} {(t%3600)//60} {t%60}\n")
    else:
        m,n = map(int,aa.split())
        if m==1:
            t+=n
        else:
            t-=n