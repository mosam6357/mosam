a = int(input())
cnt = 0
for i in range(1,a+1):
    b = str(i)
    s = 0
    for j in b:
        s+=int(j)
    if i%s==0:
        cnt+=1
print(cnt)