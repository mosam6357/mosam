a=int(input())
if(-32768<=a and a<=32767):
    print('short')
elif(-2147483648<=a and a<=2147483647):
    print('int')
else:
    print('long long')