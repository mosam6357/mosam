def solution(my_string, is_suffix):
    if len(is_suffix)>len(my_string):return 0
    if is_suffix==my_string[len(my_string)-len(is_suffix):]:return 1
    return 0