b = int(input())
aa = [0,1,2,3,5]
j=5
while(len(aa)<=b):
    aa.append(aa[j-1]+aa[j-2])
    j+=1
print(aa[b]%10007)