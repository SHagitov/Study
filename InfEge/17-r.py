file = open('17_2399.txt')
a = [int(i) for i in file]

k = sum([sum(map(int, str(x))) for x in a if x % 35 == 0])
ans = []
for i in range(len(a) - 1):
    if (a[i] > k and a[i + 1] < k and hex(a[i + 1])[-2:] == 'ef') or \
            (a[i + 1] > k and a[i] < k and hex(a[i])[-2:] == 'ef'):
        ans += [a[i] + a[i + 1]]
print(len(ans), min(ans))
