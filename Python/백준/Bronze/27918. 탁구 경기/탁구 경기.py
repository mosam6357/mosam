n=int(input())
d=0
p=0
for i in range(n):
    a = input()
    if a=='D':
        d+=1
    else:
        p+=1
    if(i==n-1 or d-p==2 or p-d==2):
        print(f'{d}:{p}')
        break