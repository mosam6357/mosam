a = int(input())
s = input()
c = 0
cnt = 0
for i in s:
    if i=='1':
        c=3
    if c>0:
        cnt+=1
        c-=1
print(cnt)