a=int(input()); aa=[]
for i in range(a):
    b,c = map(int,input().split())
    aa.append(b*c)
print(max(aa))