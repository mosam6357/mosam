aa=[]
for i in range(3):
    aa.append(input())
    if(aa[i].isdigit()):
        a=int(aa[i])+3-i
if(a%3==0 and a%5==0):
    print('FizzBuzz')
elif(a%3==0):
    print('Fizz')
elif(a%5==0):
    print('Buzz')
else:
    print(a)