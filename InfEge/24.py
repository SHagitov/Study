def f(s):
    if s.count('A') >= 2 and s.count('T') >= 2:
        sub = s[s.find('A'):s.rfind('A') + 1]
        if any(f'T{x}T' in sub for x in set(s)):
            return 1
    else:
        return 0

s = open('24.txt').readline()
index_x = [i for i in range(len(s)) if s[i] == 'X']
count = 0

for i in range(len(index_x)):
    for j in range(i + 1, len(index_x)):
        if f(s[index_x[i]: index_x[j] + 1]):
            count += 1
print(count)
