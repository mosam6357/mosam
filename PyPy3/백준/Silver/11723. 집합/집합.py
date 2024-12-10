import sys

a = int(sys.stdin.readline())
s = set()
q=0
for i in range(a):
    b = sys.stdin.readline().strip()
    if(b=='all'):
        s = {j+1 for j in range(20)}
    elif(b=='empty'):
        s = set()
    else:
        aa = b.split()
        c = int(aa[1])
        if(b[0]=='a'):
            if(c not in s):
                s.add(c)
        elif(b[0]=='r'):
            if(c in s):
                s.remove(c)
        elif(b[0]=='c'):
            if(c in s):
                sys.stdout.write('1\n')
            else:
                sys.stdout.write('0\n')
        elif(b[0]=='t'):
            if(c in s):
                s.remove(c)
            else:
                s.add(c)