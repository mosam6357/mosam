a = input()
b = input()
cnt = 0
for i in range(4):
    if a[i]==b[i]:
        cnt+=1
power = 4-cnt
print(2**(power))