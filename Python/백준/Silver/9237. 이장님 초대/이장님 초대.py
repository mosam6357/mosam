a=int(input())
b=list(map(int,input().split()))
b.sort(reverse = True)
for i in range(a):
    b[i]+=i+1
print(max(b)+1)