def count(n): #약수의 개수
    cnt = 0
    for i in range(1,n+1):
        if n%i==0:
            cnt+=1
    return cnt

a = int(input())
for i in range(a):
    n = int(input())
    print(n,count(n))