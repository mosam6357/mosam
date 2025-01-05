a = int(input())
aa = {}
for i in range(a):
    s = input().split()
    aa[s[1]] = s[0]
bb = input()
for i in range(len(bb)//4):
    b = bb[i*4:i*4+4]
    if b in aa.keys():
        print(aa[b],end ="")
    else:
        print('?',end="")