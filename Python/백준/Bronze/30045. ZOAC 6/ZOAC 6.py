a = int(input())
cnt = 0
for i in range(a):
    b = input()
    if 'OI' in b or '01' in b:
        cnt+=1
print(cnt)