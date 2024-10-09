score=0
for i in range(8):
    a=input()
    m=0; p=0
    for j in range(8):
        if(a[j]!='.' and a[j].upper()!='K'):
            if(a[j].isupper()):
                m=1
            else:
                m=-1
            c=a[j].upper()
            if(c=='P'):
                p=1
            elif(c=='N' or c=='B'):
                p=3
            elif(c=='R'):
                p=5
            else:
                p=9
            score+=m*p
print(score)