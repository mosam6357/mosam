a=int(input())
for i in range(a):
    aa = list(map(int,input().split()))
    print(f"Case #{i+1}: {max(aa)}")