a = int(input())
for i in range(a):
    b = int(input())
    s1 = b*(b+1)//2 #처음 n개의 양의 정수의 합
    s2 = b*b #처음 n개의 양의 홀수의 합
    s3 = b*b+b #처음 n개의 양의 짝수의 합
    print(f"{s1} {s2} {s3}")