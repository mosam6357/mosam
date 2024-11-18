aa=[0,4,11,23,40,60,77,89,96,100]
n,k = map(int,input().split())
bb=list(map(float,input().split()))
for i in range(k):
    a = (bb[i]*100)//n
    for j in range(9):
        if(aa[j]<=a and a<=aa[j+1]):
            print(j+1,end=" ")
            break