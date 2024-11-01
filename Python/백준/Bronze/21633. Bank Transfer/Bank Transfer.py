a=int(input())
b=25+a*0.01
if(b>2000):
    print('2000.00')
elif(b<100):
    print('100.00')
else:
    print(f'{b:.2f}')