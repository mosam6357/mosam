a = int(input())
for i in range(a):
    b = int(input())
    ans = 1
    for j in range(b):
        ans*=j+1
    print(ans%10)