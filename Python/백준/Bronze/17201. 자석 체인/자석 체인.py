a = int(input())
s = input()
for i in range(1,a*2):
    if (s[i-1]==s[i]):
        print('No')
        break
    if i==a*2-1:
        print('Yes')