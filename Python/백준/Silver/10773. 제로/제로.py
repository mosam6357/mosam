a=int(input())
aa=[]
for i in range(a):
    b=int(input())
    if(b==0):
        del aa[len(aa)-1]
    else:
        aa.append(b)
print(sum(aa))