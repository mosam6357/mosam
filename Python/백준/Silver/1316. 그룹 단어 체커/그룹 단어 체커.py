a=int(input())
check=a
for i in range(a):
    x=input()
    l=len(x)
    for j in range(0,l-1):
        if(x[j]!=x[j+1]):
            if(x[j] in x[j+1:]):
                check=check-1
                break      
print(check)