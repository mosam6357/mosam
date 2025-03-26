i=1
while(True):
    ck=0
    aa = list(map(int,input().split()))
    if (i!=1):
        print('')
    if min(aa)==max(aa):
        break
    s = chr(aa.index(-1)+97)
    if (aa.index(-1)==2):
        ck=1
    elif(aa[2]!=max(aa) or (aa[0]==aa[2] or aa[1]==aa[2])):
        ck=2
    print(f'Triangle #{i}')
    aa.remove(-1)
    if ck==2:
        print('Impossible.')
    else:
        if (ck==0):
            n = (max(aa)**2-min(aa)**2)**0.5
        else:
            n = (min(aa)**2+max(aa)**2)**0.5
        print(f'{s} = {n:.3f}')
    i+=1