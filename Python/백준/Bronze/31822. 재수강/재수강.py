q = input()[:5]
a = int(input())
cnt = 0
for i in range(a):
    b = input()[:5]
    if(q==b):
        cnt+=1
print(cnt)