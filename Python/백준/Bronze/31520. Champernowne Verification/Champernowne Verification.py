s = ""
a = input()
i = 1
while(True):
    s+= str(i)
    if a==s:
        print(i)
        break
    if len(s)>len(a):
        print(-1)
        break
    i+=1