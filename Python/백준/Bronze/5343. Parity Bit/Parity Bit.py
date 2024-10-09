a=int(input())
for i in range(a):
    b = input()
    error = 0
    for j in range(len(b)//8):
        c=b[j*8:j*8+8]
        cnt=0
        for k in range(7):
            if(c[k]=='1'):
                cnt+=1
        if(cnt%2!=int(c[7])):
            error+=1
    print(error)