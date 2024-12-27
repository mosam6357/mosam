aa=[]
while(True):
    try:
        a = input()
        aa.append(list(map(int,a.split())))
    except:
        x=0
        y=0
        for i in a:
            if i=='U' and [x,y+1] not in aa:
                y+=1
            if i=='D' and [x,y-1] not in aa:
                y-=1
            if i=='L' and [x-1,y] not in aa:
                x-=1
            if i=='R' and [x+1,y] not in aa:
                x+=1
        print(x,y)
        break