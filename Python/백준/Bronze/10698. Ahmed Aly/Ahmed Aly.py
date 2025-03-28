a = int(input())
for i in range(a):
    aa = input().split()
    n = eval(aa[0]+aa[1]+aa[2])
    if (n==int(aa[4])):
        print(f"Case {i+1}: YES")
    else:
        print(f"Case {i+1}: NO")