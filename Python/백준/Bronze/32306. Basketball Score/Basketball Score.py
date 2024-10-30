aa=[]
for i in range(2):
    a,b,c = map(int,input().split())
    aa.append(a+b*2+c*3)
if(aa[0]==aa[1]):
    print(0)
elif(aa[0]>aa[1]):
    print(1)
else:
    print(2)