aa=[0 for i in range(10)]
for i in range(10):
    aa[i] = int(input())
for i in range(10):
    if(sum(aa)-aa[i] == aa[i]):
        print(aa[i])
        break