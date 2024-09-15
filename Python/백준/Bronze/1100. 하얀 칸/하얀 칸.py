sum=0
for i in range(8):
    aa=input()
    for j in range(4):
        if (aa[j*2+(i%2)]=='F'):
            sum+=1
print(sum)