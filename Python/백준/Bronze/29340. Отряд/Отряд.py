a=input()
b=input()
for i in range(len(a)):
    if(a[i]>b[i]):
        print(a[i],end="")
    else:
        print(b[i],end="")