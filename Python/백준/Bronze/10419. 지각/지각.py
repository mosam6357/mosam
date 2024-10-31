a = int(input())
for i in range(a):
    b = int(input())
    i = 0
    while(True):
        j = i+1
        if(j*j+j<=b):
            i+=1
        else:
            break
    print(i)