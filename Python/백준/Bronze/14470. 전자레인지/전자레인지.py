a=[]
time=0
for i in range(5):
    a.append(int(input()))
while(a[0]<a[1]):
    if(a[0]<0):
        time+=a[2]
        a[0]+=1
    elif(a[0]==0):
        time+=a[3]+a[4]
        a[0]+=1
    else:
        time+=a[4]
        a[0]+=1
print(time)