money = int(input())
aa = []
for i in range(3):
    aa.append(int(input()))
if (aa[0]<=money):
    print('Watermelon')
elif (aa[1]<=money):
    print('Pomegranates')
elif (aa[2]<=money):
    print('Nuts')
else:
    print('Nothing')