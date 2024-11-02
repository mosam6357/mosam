a=int(input())
for i in range(a):
    b=input()
    walk = 0
    for j in b:
        if(j=='D'):
            break
        else:
            walk+=1
    print(walk)