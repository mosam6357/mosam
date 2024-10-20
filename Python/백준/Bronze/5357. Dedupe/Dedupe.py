q=int(input())
for i in range(q):
    aa=[]
    a=input()
    for j in range(len(a)):
        if(j==0):
            aa.append(a[0])
        else:
            if(a[j]!=aa[len(aa)-1]):
                aa.append(a[j])
    for k in aa:
        print(k,end="")
    print('')