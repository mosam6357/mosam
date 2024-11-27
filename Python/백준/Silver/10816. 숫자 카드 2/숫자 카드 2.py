import sys

a=int(sys.stdin.readline().strip())
aa = list(map(int,sys.stdin.readline().split()))
b=int(sys.stdin.readline().strip())
bb = list(map(int,sys.stdin.readline().split()))
cc={}
for i in aa:
    try:
        cc[i]+=1
    except:
        cc[i]=1
for i in bb:
    try:
        print(cc[i],end=" ")
    except:
        print(0,end=" ")