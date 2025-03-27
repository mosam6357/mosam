t = int(input())
for i in range(t):
    a,b = map(int,input().split())
    print(f'Data Set {i+1}:')
    if (a<=b):
        print('no drought\n')
    else:
        n=1
        s = ''
        while(True):
            if (b*n<a and a<=5*b*n):
                s+='drought'
                break
            else:
                s+='mega '
                n*=5
        print(s)
        print()