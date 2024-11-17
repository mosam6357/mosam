a = int(input())
b = int(input())
print(f"All positions change in year {a}")
for i in range(a+1,b+1):
    if((i-a)%60==0):
        print(f"All positions change in year {i}")