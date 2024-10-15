a=int(input())
b=input()
ck=True
for i in range(1,a):
    if(b[i]!=b[0]):
        ck=False
if(ck):
    print('Yes')
else:
    print('No')