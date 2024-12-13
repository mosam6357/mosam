a = input()
if(len(a)<5):
    print('not cute')
elif(a[len(a)-5:]!='driip'):
    print('not cute')
else:
    print('cute')