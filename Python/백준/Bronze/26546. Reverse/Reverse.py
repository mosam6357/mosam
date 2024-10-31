a = int(input())
for i in range(a):
    aa = input().split()
    b = aa[0]
    print(b[:int(aa[1])]+b[int(aa[2]):])