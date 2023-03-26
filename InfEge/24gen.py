import random
import string
from random import randint

CONST = 1000000
a = set()
symbols = [i for i in string.ascii_uppercase]
Z = sorted(set(symbols) - {'X'})
data = ['X' for x in range(14)]
while len(data) < CONST:
    data.append(str(random.choice(Z)))
random.shuffle(data)
my_file = open("24.txt", "w+")
COUNTER = 0
for _ in range(len(data) - ((len('XATTTAXAXATTTAX')) * (CONST // 125_000))):
    if (0 < _ < CONST) and (_ % 125_000 == 0):
        my_file.write('XATAAXTXTXAATAX')
        COUNTER += 15
    my_file.write(str(data[_]))
    COUNTER += 1
for _ in range(len(data)):
    if COUNTER < CONST:
        my_file.write(str(data[_]))
        COUNTER += 1
my_file.close()
