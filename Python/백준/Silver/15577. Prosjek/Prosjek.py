a = int(input())
aa = []
for i in range(a):
    aa.append(int(input()))
aa.sort()
aa.reverse()
for i in range(a-1):
    x = aa.pop()
    y = aa.pop()
    aa.append((x+y)/2)
print(aa[0])