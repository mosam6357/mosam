aa=[]
for i in range(5):
    a=input()
    if a in aa:
        aa.remove(a)
    else:
        aa.append(a)
print(*aa)