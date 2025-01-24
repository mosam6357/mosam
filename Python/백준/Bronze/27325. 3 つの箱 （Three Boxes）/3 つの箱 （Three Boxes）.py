a = int(input())
cnt = 0
x = 1
aa = input()
for i in aa:
    if i=='L' and x!=1:
        x-=1
    elif i=='R' and x!=1:
        cnt+=1
        x=3
    elif i=='R' and x==1:
        x+=1
print(cnt)