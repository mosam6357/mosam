i=1
while(True):
    aa = list(map(int,input().split()))
    if(len(aa)==1):
        break
    del aa[0]
    if(len(aa)%2==0):
        avg = (aa[len(aa)//2-1]+aa[len(aa)//2])/2
        print(f"Case {i}: {avg:.1f}")
    else:
        print(f"Case {i}: {aa[len(aa)//2]:.1f}")
    i+=1