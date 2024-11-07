a,b =  map(int,input().split())
cnt = 0
for i in range(a):
    aa = input()
    if '+' in aa:
        cnt+=1
print(cnt)