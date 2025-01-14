a = int(input())
s1 = input()
s2 = input()
cnt = 0
for i in range(a):
    if s1[i]==s2[i] and s1[i]=='C':
        cnt+=1
print(cnt)