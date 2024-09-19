q=[3,4,7,8,11,12]; a=int(input()); s=1; b=a%14
w=["baby","sukhwan","tururu","turu","very","cute", "tururu", "turu","in","bed","tururu","turu","baby","sukhwan"]
if b in q:
    if(a%2==1):
        s+=1
    s+=a//14
    if(s>=5):
        print(f"tu+ru*{s}")
    else:
        t="ru"*s
        print("tu"+t)
else:
    print(w[(a-1)%14])
