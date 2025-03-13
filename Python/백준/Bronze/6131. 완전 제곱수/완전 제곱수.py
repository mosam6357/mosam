n = int(input())
cnt = 0
for i in range(2,1000):
    for j in range(1,i):
        if i*i==j*j+n:
            cnt+=1
print(cnt)