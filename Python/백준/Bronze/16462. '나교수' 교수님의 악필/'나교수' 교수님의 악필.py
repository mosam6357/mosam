a=int(input()); sum=0
for i in range(a):
    b=input(); d=''
    for j in range(len(b)):
        if(b[j]=='6' or b[j]=='0'):
            d+='9'
        else:
            d+=b[j]
    c=int(d)
    if(c>100):
        c=100
    sum+=c
if(sum/a-round(sum/a)==0.5):
    print(round(sum/a)+1)
else:
    print(round(sum/a))