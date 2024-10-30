a = int(input())
for i in range(a):
    n,a,d = map(int,input().split())
    print(int(n*(a+((n-1)*d)/2)))