a = int(input())
for i in range(a):
    ans = 0
    b = int(input())
    aa = list(map(int,input().split()))
    bb = list(map(int,input().split()))
    aa.sort()
    bb.sort(reverse="True")
    for j in range(b):
        ans+=aa[j]*bb[j]
    print(f"Case #{i+1}: {ans}")