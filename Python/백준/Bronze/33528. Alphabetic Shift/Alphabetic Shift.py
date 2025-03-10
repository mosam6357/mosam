a = input()
for i in range(26):
    print(a)
    s = ''
    for j in a:
        if j=='A':
            s+='Z'
        else:
            s+=chr(ord(j)-1)
    a=s