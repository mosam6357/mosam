a=int(input()); s=5; sum=0
for i in range(a//5):
    sum+=1
    if((s//5)%5==0):
        sum+=1
        if((s//25)%5==0):
            sum+=1
    s+=5
print(sum)
