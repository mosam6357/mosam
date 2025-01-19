t = 1
while(True):
    ck = 0 #0은 false, 1은 true
    s = input().split()
    n1 = int(s[0])
    n2 = int(s[2])
    x = s[1]
    if (x=='E'):
        break
    elif (x=='==' and n1==n2):
        ck=1
    elif (x=='!=' and n1!=n2):
        ck=1
    elif (x=='>' and n1>n2):
        ck=1
    elif (x=='>=' and n1>=n2):
        ck=1
    elif(x=='<' and n1<n2):
        ck=1
    elif (x=='<='and n1<=n2):
        ck=1
    if ck:
        print(f"Case {t}: true")
    else:
        print(f"Case {t}: false")
    t+=1