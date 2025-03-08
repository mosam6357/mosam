a = int(input())
for i in range(a):
    s = input()
    total = 0
    for j in range(26):
        if s.count(chr(65+j))==0:
            total+=65+j
    print(total)