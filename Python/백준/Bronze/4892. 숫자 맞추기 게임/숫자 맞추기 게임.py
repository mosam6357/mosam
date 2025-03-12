i=1
while(True):
    a = int(input())
    if a==0:
        break
    if a%2==0:
        print(f'{i}. even {a//2}')
    else:
        print(f'{i}. odd {(a-1)//2}')
    i+=1