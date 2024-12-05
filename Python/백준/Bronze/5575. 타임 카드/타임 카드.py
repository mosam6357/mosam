for i in range(3):
    aa = list(map(int,input().split()))
    time1 = aa[0]*3600+aa[1]*60+aa[2]
    time2 = aa[3]*3600+aa[4]*60+aa[5]
    time = time2 - time1
    print(time//3600,(time-(time//3600)*3600)//60,time%60)