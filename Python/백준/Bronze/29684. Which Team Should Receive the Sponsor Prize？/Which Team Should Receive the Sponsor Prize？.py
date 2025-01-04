while(True):
    a = int(input())
    if a==0:
        break
    aa = list(map(int,input().split()))
    bb = []
    for i in aa:
        bb.append(abs(2023-i))
    print(bb.index(min(bb))+1)