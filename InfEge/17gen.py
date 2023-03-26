import random
from random import randint

a = set()
while len(a) < 2500:
    x = random.randrange(0, 100_000, 1)
    if x != 0 and x % 5 == 0 and len(str(abs(x))) >= 5:
        a.add(x)
while len(a) < 5000:
    x = random.randrange(-100_000, 0, 1)
    if x != 0 and x % 5 == 0 and len(str(abs(x))) >= 3:
        a.add(x)
t = set()
while len(t) < 2500:
    x = random.randrange(0, 100_000, 1)
    if x != 0 and x % 5 != 0 and len(str(abs(x))) >= 3:
        t.add(x)
while len(t) < 5000:
    x = random.randrange(-100_000, 0, 1)
    if x != 0 and x % 5 != 0 and len(str(abs(x))) >= 3:
        t.add(x)
t = sorted(t)
t[0] = 50
random.shuffle(t)
print(len(a))
print(a)
print(len(t))
print(t)
my_file = open("17.txt", "w+")
for i1, i2 in zip(a, t):
    my_file.write(str(i1))
    my_file.write('\n')
    my_file.write(str(i2))
    my_file.write('\n')
my_file.close()
