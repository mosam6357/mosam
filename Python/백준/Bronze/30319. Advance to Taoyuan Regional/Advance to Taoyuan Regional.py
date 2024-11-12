a=list(map(int,input().split('-')))
if(a[1]>9 or (a[1]==9 and a[2]>16)):
    print('TOO LATE')
else:
    print('GOOD')