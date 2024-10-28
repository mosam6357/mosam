aa = input().split()
bb = input().split()
if bb[0] in aa:
    print(aa.index(bb[0])+1)
else:
    print(0)