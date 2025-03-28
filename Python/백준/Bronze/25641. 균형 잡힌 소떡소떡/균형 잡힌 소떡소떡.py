a = int(input())
s = input()
for i in range(a):
    if (s.count('s')==s.count('t')):
        print(s)
        break
    else:
        s = s[1:]