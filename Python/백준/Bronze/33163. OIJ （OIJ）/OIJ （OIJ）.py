a = int(input())
aa = input()
s = ""
for i in aa:
    if i=='O':
        s+='I'
    elif i=='J':
        s+='O'
    else:
        s+='J'
print(s)