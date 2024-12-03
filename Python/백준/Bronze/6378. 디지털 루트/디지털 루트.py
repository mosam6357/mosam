def numsum(a):
    s = 0
    for i in a:
        s+=int(i)
    if(s>9):
        return numsum(str(s))
    else:
        return s

while(True):
    a = input()
    if(a=='0'):
        break
    print(numsum(a))
    