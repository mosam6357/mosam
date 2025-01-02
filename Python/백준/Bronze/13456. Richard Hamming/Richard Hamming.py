a = int(input())
for i in range(a):
    b = int(input())
    aa = input().split()
    bb = input().split()
    cnt =0
    for j in range(b):
        if(aa[j]!=bb[j]):
            cnt+=1
    print(cnt)