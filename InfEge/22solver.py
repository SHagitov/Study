from csv import reader

with open("22.csv", encoding="cp1251") as F:
    rdr = reader(F, delimiter=';', quotechar='"')
    next(rdr)  # читаем заголовки и пропускаем их
    data = {}
    finalTime = {}
    for s in rdr:
        id, t = int(s[0]), int(s[1])
        dependsOn = list(map(int, s[2].split(';')))
        if dependsOn == [0]:
            finalTime[id] = t  # известно время окончания
        else:
            data[id] = (t, dependsOn)  # неизвестно время окончания

print(data)
print(finalTime)

while data:
    ids = list(data.keys())
    for id in ids:
        t, dependsOn = data[id]
        if all((x in finalTime) for x in dependsOn):
            startId = max(finalTime[x] for x in dependsOn)
            finalTime[id] = startId + t
            del data[id]

print(data)
print(finalTime)
print("Ответ:", max(finalTime.values()))
