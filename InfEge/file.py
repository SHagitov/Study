from itertools import *


def f(x, y, w, z):
    return z or (not (w <= x)) or ((not z) <= (not y))


counter = 0
for a1, a2, a3, a4, a5, a6 in product([0, 1], repeat=6):
    table = [(a1, 0, 1, 1), (1, a2, 1, a3), (a4, a5, a6, 1)]
    if len(table) == len(set(table)):
        for p in permutations('xywz'):
            if [f(**dict(zip(p, r))) for r in table] == [0, 0, 0]:
                print(p)
