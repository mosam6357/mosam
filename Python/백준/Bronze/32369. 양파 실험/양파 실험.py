n,a,b = map(int,input().split())
o1 = 1
o2 = 1
for i in range(n):
    o1+=a
    o2+=b
    if(o1==o2):
        o2-=1
    elif(o1<o2):
        temp = o2
        o2 = o1
        o1 = temp
print(o1,o2)