aa = list(map(int,input().split()))
aa.sort()
if (aa[1]-aa[0]==aa[2]-aa[1]):
    print(aa[2]+(aa[2]-aa[1]))
elif (aa[1]-aa[0]>aa[2]-aa[1]):
    print(aa[1]-(aa[2]-aa[1]))
elif (aa[1]-aa[0]<aa[2]-aa[1]):
    print(aa[2]-(aa[1]-aa[0]))