a = int(input())
for i in range(a+2):
    if i!=0 and i!=a+1:
        print('@',end='')
        print(' '*a,end='')
        print('@')
    else:
        print('@'*(a+2))