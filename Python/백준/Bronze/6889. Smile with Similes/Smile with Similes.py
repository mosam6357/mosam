a = int(input())
b = int(input())
aa = []
bb = []
for i in range(a):
    aa.append(input())
for i in range(b):
    bb.append(input())
for i in aa:
    for j in bb:
        print(f"{i} as {j}")