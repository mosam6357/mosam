aa=input().split(); a=int(aa[0]); b=int(aa[1]); sum1=0; sum=0
for i in range(len(aa[0])):
    sum1+=int(aa[0][i])
for i in range(len(aa[1])):
    sum+=sum1*int(aa[1][i])
print(sum)