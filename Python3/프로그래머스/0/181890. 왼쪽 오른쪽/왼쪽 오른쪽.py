def solution(str_list):
    for i in range(len(str_list)):
        if str_list[i]=='l':
            if i==0:
                return []
            return str_list[:i]
        elif str_list[i]=='r':
            if i==len(str_list)-1:
                return []
            return str_list[i+1:]
    return []