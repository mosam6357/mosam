a=[0 for i in range(3)]
for i in range(3):
    a[i] = int(input())
for i in range(3):
    if(a[i]!=max(a) and a[i]!=min(a)):
        print(a[i])