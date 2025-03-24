a = input()
cnt = 0
n = int(a)
while(n>=10):
    nn = 1
    for i in a:
        nn*=int(i)
    a = str(nn)
    cnt += 1
    n = nn
print(cnt)