while(True):
    try:
        a = input()
        b = ''
        for i in a:
            if i=='E':
                b+='I'
            elif i=='I':
                b+='E'
            elif i=='e':
                b+='i'
            elif i=='i':
                b+='e'
            else:
                b+=i
        print(b)
    except:
        break