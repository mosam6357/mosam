aa = set()
for i in range(1,10):
    aa.add(i)
    for j in range(1,10):
        aa.add(i*j)
a = int(input())
if a in aa:
    print(1)
else:
    print(0)