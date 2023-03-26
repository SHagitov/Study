data = [int(i) for i in open('17-354.txt')]
mn = min(i for i in data if i >= 0)
ans = []
for i1, i2 in zip(data, data[1:]):
    a, b = map(abs, (i1, i2))
    if (a % 11) + (b % 11) == mn:
        ans += [i1 + i2]
print(len(ans), min(ans))
