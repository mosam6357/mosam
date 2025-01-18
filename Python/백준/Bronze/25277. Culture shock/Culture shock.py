a = int(input())
aa = input().split()
ban = ['he','she','him','her']
cnt = 0
for i in ban:
    cnt+=aa.count(i)
print(cnt)