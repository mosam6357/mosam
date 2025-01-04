a = int(input())
aa = []
for i in range(1,a+1):
    if a%i==0:
        aa.append(i)
print(sum(aa))