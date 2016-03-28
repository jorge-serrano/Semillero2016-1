def function(var1):
    A = [5, 3, 6, 3, 4, 2]
    b = 0
    for i in range(len(A)):
        for j in range(len(A)):
            if i>=0 and j>=i:
                if A[i] <= A[j]:
                    print(i, ",", j)
                    c = abs(j - i)
                    if c > b:
                        b = c
                        d = str(b) + "  en  " + str(i) + "." + str(j)
    print("La mayor distancia es: ", d)

def function2(var1):
    A = [5, 3, 6, 3, 4, 2]
    f = []
    b = 0
    g = 0
    def Dist(y, x):
        if x > y:
            text1 = str(x) + "." + str(y)
            f.append([text1, x-y])
        if y > x:
            text2 = str(x) + "." + str(y)
            f.append([text2, y-x])
    for i in range(len(A)):
        for j in range(len(A)):
            if i>=0 and j>=i:
                if A[i] <= A[j]:
                    print(i, ",", j)
                    Dist(j, i)
    for i in range(len(f)):
        if f[i][1] > g:
            g = f[i][1]
            h = f[i]
    print("La mayor distancia es: ", h)
'''
def function3(var1):
    A = [5, 3, 6, 3, 4, 2]
    f = []
    b = 0
    global k 
    k = 0
    def Dist(y, x):
        if x > y:
            f.append([str(x) + "." + str(y), x-y])
        if y > x:
            f.append([str(x) + "." + str(y), y-x])
    def vector(VectA, g):
        for i in range(len(VectA)):
            if k == 1:
                    if f[i][1] > g:
                        g = f[i][1]
                        h = f[i]
            else:
                for j in range(len(VectA)):
                    if i>=0 and j>=i:
                        if A[i] <= A[j]:
                            print(i, ",", j)
                            Dist(j, i)
                            h = 0
            global k 
        k = 1
        return h
    w = vector(A, 0)
    w = vector(f, 0)
    print("La mayor distancia es: ", w)
'''
var1 = int(input())
if var1 == 0:
    function(var1)
elif var1 == 1:
    function2(var1)