a = int(input())
for i in range(a):
    b = int(input())
    s = input()
    while(s.replace('ABB','BA') != s):
        s = s.replace('ABB','BA')
    print(s)