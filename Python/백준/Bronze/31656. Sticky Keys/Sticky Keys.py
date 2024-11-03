a=input()
for i in range(len(a)):
    if i == len(a)-1:
        print(a[i])
    elif(a[i]!=a[i+1]):
        print(a[i],end="")