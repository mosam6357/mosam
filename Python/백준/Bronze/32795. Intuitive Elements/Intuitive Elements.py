q = int(input())
for i in range(q):
    s = input()
    a = input()
    for i in range(len(a)):
        if a[i] not in s:
            print('NO')
            break
        if i==len(a)-1:
            print('YES')