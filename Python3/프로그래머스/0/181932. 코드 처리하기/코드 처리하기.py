def solution(code):
    ret = ''
    mode = 0
    for i in range(len(code)):
        if mode == 0:
            if i%2==0 and code[i]!="1":
                ret+=code[i]
            if code[i]=="1":
                mode = 1
        else:
            if i%2==1 and code[i]!="1":
                ret+=code[i]
            if code[i]=="1":
                mode = 0
    if ret == "":
        return "EMPTY"
    return ret