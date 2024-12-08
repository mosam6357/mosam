import sys

a = int(sys.stdin.readline())
aa = []
for i in range(a):
    b = sys.stdin.readline()
    if(b[:2]=="pu"):
        bb = b.split()
        aa.append(bb[1])
    elif(b[0]=="p"):
        try:
            sys.stdout.write(aa.pop()+'\n')
        except:
            sys.stdout.write('-1\n')
    elif(b[0]=="s"):
        sys.stdout.write(f'{len(aa)}\n')
    elif(b[0]=="e"):
        if(len(aa)==0):
            sys.stdout.write('1\n')
        else:
            sys.stdout.write('0\n')
    else:
        try:
            sys.stdout.write(aa[len(aa)-1]+'\n')
        except:
            sys.stdout.write('-1\n')