l = int(input())
s1 = input()
n1 = input()
s2 = input()
n2 = input()
s = ''
for i in range(l):
    if s1[i]==s2[i]:
        if n1[i]==n2[i]:
            s+=n1[i]
        else:
            print('htg!')
            break
    if i==l-1:
        print(s)