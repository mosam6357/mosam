a = int(input())
s = input()
n2 = s.count('2')
ne = s.count('e')
if (n2==ne):
    print('yee')
elif (n2>ne):
    print('2')
else:
    print('e')