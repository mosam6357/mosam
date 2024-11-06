a=input()
if(a[0]=="\"" and a[len(a)-1]=="\"" and len(a)!=1):
    if(len(a.replace(" ",""))==2):
        print("CE")
    else:
        print(a[1:len(a)-1])
else:
    print("CE")