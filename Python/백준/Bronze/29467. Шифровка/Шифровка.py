s = input()
aa = [s[i:] for i in range(len(s))]
aa.sort()
print(aa[len(aa)-1])