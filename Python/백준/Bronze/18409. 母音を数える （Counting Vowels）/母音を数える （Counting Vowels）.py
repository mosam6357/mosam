q=int(input())
a=['a','e','i','o','u']
b=input(); sum=0
for i in range(q):
    if b[i] in a:
        sum+=1
print(sum)