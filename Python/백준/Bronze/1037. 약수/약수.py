x=int(input())
y=input().split()
z=[0]*50
for i in range(len(y)):
    z[i]=int(y[i])
while 0 in z:
    z.remove(0)
a=max(z)*min(z)
print(a)
