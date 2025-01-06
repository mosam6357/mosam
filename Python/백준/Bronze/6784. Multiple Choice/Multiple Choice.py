n = int(input())
aa = []
cnt = 0
for i in range(n):
    aa.append(input())
for i in range(n):
    if input()==aa[i]:
        cnt+=1
print(cnt)