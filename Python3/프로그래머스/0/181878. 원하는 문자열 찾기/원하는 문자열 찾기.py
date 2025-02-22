def solution(myString, pat):
    cnt = myString.upper().count(pat.upper())
    if cnt>0:
        return 1
    return 0