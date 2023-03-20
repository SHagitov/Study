a = [int(x) for x in open('17.txt')]
k5 = len([i for i in a if i % 5 == 0])
ans = []
for i1, i2 in zip(a, a[1:]):
    if (((i1 < 0) + (i2 < 0)) == 1) and (i1 + i2 < k5):
        ans += [i1 + i2]
print(len(ans), max(ans))
