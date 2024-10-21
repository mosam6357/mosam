a=int(input()) #쓸 연료
b=int(input())+60 #할당량
if(a>=b):
    print(b*1500+(a-b)*3000)
else:
    print(a*1500)