a = int(input())
ans = 0
for i in range(a):
    if i==0:
        ans = 5
    else:
        ans+=(i+2)*3-2
print(ans%45678)