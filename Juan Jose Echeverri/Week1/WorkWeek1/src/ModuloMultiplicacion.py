var1 = int(input())
var2 = int(input())
var3 = 0
for i in range(abs(var2)):
    var3 = var3 + var1
if (var1 < 0 and var2 < 0):
    var3 = abs(var3)
if var2 < 0:
    var3 = var3 - var3 - var3
print(var3)