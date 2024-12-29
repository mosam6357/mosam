aa = []
cnt = 0
a = int(input())
for i in range(a):
    aa.append(input())
b = int(input())
for i in range(b):
    if input() in aa:
        cnt+=1
print(cnt)