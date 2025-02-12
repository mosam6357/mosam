a = int(input())
if a==1:
    print('*')
else:
    for i in range(a*2):
        if i%2==0:
            for j in range(a//2+a%2):
                print('* ',end="")
        else:
            print(' ',end="")
            for j in range(a//2):
                print('* ',end="")
        print('')          