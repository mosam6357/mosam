pw = "ILOVEYONSEI"
a = input()
step = 0
for i in pw:
    step+=abs(ord(a)-ord(i))
    a = i
print(step)