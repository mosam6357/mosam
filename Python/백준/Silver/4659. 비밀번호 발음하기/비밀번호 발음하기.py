aa = ['a','e','i','o','u']
while(True):
    s = input()
    l = len(s)
    if s=='end':
        break
    ck = 0 #디폴트 값: 부적합
    for i in aa:
        if i in s:
            ck=1 #적합 판정
            break
    if(l!=1 and l!=2):
        status = 0
        for i in range(l):
            if s[i] not in aa: #자음인 경우
                if status<0:
                    status=1
                else:
                    status+=1
            if s[i] in aa: #모음인 경우
                if status>0:
                    status=-1
                else:
                    status-=1
            if abs(status)==3:
                ck=0
                break
    if(l!=1):
        for i in range(l-1):
            if s[i]==s[i+1] and s[i]!='e' and s[i]!='o':
                ck=0
                break
    if(ck==0):
        print(f"<{s}> is not acceptable.")
    else:
        print(f"<{s}> is acceptable.")