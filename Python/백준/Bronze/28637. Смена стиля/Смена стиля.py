a = int(input())
for i in range(a):
    s = input()
    ss = ""
    for j in range(len(s)):
        if s[j].isupper():
            if j==0:
                ss+=s[j].lower()
            else:
                ss+="_"+s[j].lower()
        else:
            ss+=s[j]
    print(ss)