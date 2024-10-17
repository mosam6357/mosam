aa = list(map(int,input().split()))
if(sum(aa)<100):
    if(min(aa)==aa[0]):
        print('Soongsil')
    elif(min(aa)==aa[1]):
        print('Korea')
    else:
        print('Hanyang')
else:
    print('OK')