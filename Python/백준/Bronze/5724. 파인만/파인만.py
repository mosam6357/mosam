while(True):
    a = int(input())
    if (a==0):
        break
    cnt = 0
    for i in range(1,a+1):
        cnt+=i*i
    print(cnt)