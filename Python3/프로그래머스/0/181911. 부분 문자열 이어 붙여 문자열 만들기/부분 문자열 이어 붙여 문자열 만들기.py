def solution(my_strings, parts):
    answer = ''
    for i in range(len(parts)):
        s = my_strings[i]
        answer+=s[parts[i][0]:parts[i][1]+1]
    return answer