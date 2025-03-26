a = int(input())
s = input()
r = s[::-1]
cnt = 0
for i in range(a):
    if s[i]!=r[i]:
        cnt+=1
print(cnt//2)