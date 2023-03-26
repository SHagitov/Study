from fnmatch import *

s = open('24.txt').readline()
count = 0
index_x = [i for i in range(len(s)) if s[i] == 'X']
for i in range(len(index_x)):
    for j in range(i + 1, len(index_x)):
        if fnmatch(s[index_x[i]: index_x[j] + 1], 'X*A*T?T*A*X'):
            count += 1
print(count)
