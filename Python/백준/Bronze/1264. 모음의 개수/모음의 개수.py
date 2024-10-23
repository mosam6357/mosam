aa=['a','e','i','o','u'];
while(True):
    cnt=0
    a=input().lower()
    if(a!='#'):
        for i in range(len(a)):
            if a[i] in aa:
                cnt+=1
        print(cnt)
    else:
        break