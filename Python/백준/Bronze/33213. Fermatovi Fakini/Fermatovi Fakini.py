a = int(input())
aa = list(map(int,input().split()))
n = 0
n1 = []
n2 = []
for i in aa:
    if i%2==1:
        n1.append(i)
    else:
        n2.append(i)
if len(n1)>len(n2):
    n = 1
    while(n in n1):
        n+=2
else:
    n = 2
    while(n in n2):
        n+=2
print(n)