while(True):
    a = input()
    b = []
    c = []
    d = []
    if a=='#':
        break
    for i in a:
        if i.islower():
            b.append(i)
        elif i.isupper():
            c.append(i)
        else:
            d.append(i)
    print(''.join(sorted(b)),end="")
    print(''.join(sorted(c)),end="")
    print(''.join(sorted(d)))