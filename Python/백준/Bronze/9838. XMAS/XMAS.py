a=int(input())
aa = [0 for i in range(a)]
for i in range(a):
    aa[int(input())-1] = i+1
for i in range(a):
    print(aa[i])