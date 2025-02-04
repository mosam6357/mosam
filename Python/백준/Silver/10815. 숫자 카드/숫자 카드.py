a = int(input())
aa = list(map(int,input().split()))
b = int(input())
bb = list(map(int,input().split()))
s = set(aa)&set(bb)
for i in bb:
    if i in s:
        print('1',end=" ")
    else:
        print('0',end=" ")