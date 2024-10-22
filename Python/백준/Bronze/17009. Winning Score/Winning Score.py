a=0
for i in range(3):
    a+=(3-i)*int(input())
b=0
for i in range(3):
    b+=(3-i)*int(input())
if(a==b):
    print('T')
elif(a>b):
    print('A')
else:
    print('B')