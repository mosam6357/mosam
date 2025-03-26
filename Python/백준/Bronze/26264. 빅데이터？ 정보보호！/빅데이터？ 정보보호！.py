a = int(input())
s = input()
b = s.count('bigdata')
if (b>a-b):
    print('bigdata?')
elif (2*b==a):
    print('bigdata? security!')
else:
    print('security!')