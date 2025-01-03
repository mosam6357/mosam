a = int(input())
s = 0
for i in range(a):
    aa = input()
    for j in aa:
        if j=='A':
            s+=4
        elif j=='K':
            s+=3
        elif j=='Q':
            s+=2
        elif j=='J':
            s+=1
print(s)