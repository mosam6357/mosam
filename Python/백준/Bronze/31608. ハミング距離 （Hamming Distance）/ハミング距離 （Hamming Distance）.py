a = int(input())
cnt = 0
b = input()
c = input()
for i in range(a):
    if(b[i]!=c[i]):
        cnt+=1
print(cnt)