from collections import deque
import sys

a = int(sys.stdin.readline())
aa = deque([])
for i in range(a):
    b = sys.stdin.readline()
    if(b[:2]=="pu"):
        bb = b.split()
        aa.append(bb[1])
    elif(b[0]=="p"):
        try:
            sys.stdout.write(aa.popleft()+'\n')
        except:
            sys.stdout.write('-1\n')
    elif(b[0]=="s"):
        print(len(aa))
    elif(b[0]=="e"):
        if(len(aa)==0):
            sys.stdout.write('1\n')
        else:
            sys.stdout.write('0\n')
    elif(b[0]=="f"):
        try:
            sys.stdout.write(aa[0]+'\n')
        except:
            sys.stdout.write('-1\n')
    else:
        try:
            sys.stdout.write(aa[len(aa)-1]+'\n')
        except:
            sys.stdout.write('-1\n')