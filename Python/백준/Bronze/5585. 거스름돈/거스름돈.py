a = 1000-int(input())
cnt = a//500
cnt += (a%500)//100
cnt += (a%100)//50
cnt += (a%50)//10
cnt += (a%10)//5
cnt += a%5
print(cnt)