aa={}
for i in range(7):
    a,b = input().split(); c=int(b)
    aa[a]=c
print(max(aa,key=aa.get))