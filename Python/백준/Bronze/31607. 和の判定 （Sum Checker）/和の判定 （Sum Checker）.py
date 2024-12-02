aa = []
for i in range(3):
    aa.append(int(input()))
if(max(aa) == sum(aa)-max(aa)):
    print(1)
else:
    print(0)