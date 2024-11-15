while(True):
    a=int(input())
    if(a==0):
        break
    else:
        aa = list(map(int,input().split()))
        ans = 0
        for j in range(len(aa)-2):
            num = aa[j]+aa[j+1]+aa[j+2]
            if(num>ans):
                ans = num
        print(ans)