a,b,c = map(int,input().split())
n = [i for i in range(1,a+1)]
aa = list(map(int,input().split()))
bb = list(map(int,input().split()))
l = a-len(aa)-len(bb)
print(l)
for i in aa:
    n.remove(i)
for i in bb:
    n.remove(i)
print(*n)