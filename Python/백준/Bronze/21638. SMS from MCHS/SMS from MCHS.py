a = list(map(int,input().split()))
b = list(map(int,input().split()))
if(b[0]<0 and b[1]>=10):
    print('A storm warning for tomorrow! Be careful and stay home if possible!')
elif(a[0]>b[0]):
    print('MCHS warns! Low temperature is expected tomorrow.')
elif(a[1]<b[1]):
    print('MCHS warns! Strong wind is expected tomorrow.')
else:
    print('No message')