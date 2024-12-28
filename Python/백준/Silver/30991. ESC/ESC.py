a = int(input())
aa = [0,0,1] #sin^2 x,cos^2 x,sincos x
for i in range(a): #미분 횟수
    s1 = aa[0]-aa[2]
    s2 = aa[1]+aa[2]
    s3 = 2*aa[0]-2*aa[1]+aa[2]
    aa[0]= s1
    aa[1]= s2
    aa[2]= s3
print(sum(aa))