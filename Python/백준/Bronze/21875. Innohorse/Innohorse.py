a = input()
b = input()
aa = [abs(ord(a[0])-ord(b[0])),abs(int(a[1])-int(b[1]))]
print(min(aa))
print(max(aa))