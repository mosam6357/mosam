while(True):
    try:
        aa = input().split()
        index = 0
        ck=1
        for i in aa[0]:
            while(True):
                if aa[1][index]==i:
                    index+=1
                    break
                else:
                    if index==len(aa[1])-1:
                        ck=0
                        break
                    else:
                        index+=1
        if ck==0:
            print('No')
        else:
            print('Yes')
    except:
        break