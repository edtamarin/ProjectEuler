# Project Euler Problem 14
# Egor Tamarin 2017

oldlinks = 0
for i in range(3, 1000000):
    number = i
    testedNumber = i
    numoflinks = 0
    if i%2 != 0:
        while number > 2:
            numoflinks = numoflinks + 1
            if number % 2 == 0:
                number = number / 2
            else:
                number = (3 * number) + 1
        if numoflinks > oldlinks:
            print(testedNumber)
            oldlinks = numoflinks
