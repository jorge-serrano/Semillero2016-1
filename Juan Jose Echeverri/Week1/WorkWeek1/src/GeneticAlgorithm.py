# -*- coding: utf-8 -*-
import random
def RandomStrinGenerator(Size, Chars):
    return ''.join(random.choice(Chars) for _ in range(Size))

def EvaluarVectorString(VectorRandomHijo, Puntuacion = 0):
    for i in range(Count):
        if VectorRandomHijo[i] == VectorTarget[i]:
            Puntuacion = Puntuacion + 1
    return Puntuacion

def Generate100(VectorRandomHijo, contador = 0, VectorNew = []):
    d = 0
    while contador <= 100:
        Puntuacion = EvaluarVectorString(VectorRandomHijo)
        for _ in range(Percent):
            RandomPosition = random.randrange(Count)
            if VectorRandomHijo[RandomPosition] != VectorTarget[RandomPosition]:
                VectorRandomHijo[RandomPosition] = random.choice(Chars)
        contador = contador + 1
        if Puntuacion > d:
            d = Puntuacion
            VectorNew = VectorRandomHijo      
    return VectorNew, Puntuacion
'''METHINKS IT IS LIKE A WEASEL'''
Target = str(input("Escriba una Palabra de 28 caracteres o mas: "))
Count = len(Target)
Percent = 1 if round(Count * 0.05) == 0 else round(Count * 0.05)
VectorTarget = list(Target.upper())
Chars="ABCDEFGHIJKLMNOPQRSTUVWQYZ "
VectorRandom = list(RandomStrinGenerator(Count, Chars))
ContadorGeneracion = 0
Puntuacion = 0
while Puntuacion < Count:
    VectorRandomHijo,Puntuacion = Generate100(VectorRandom, ContadorGeneracion)
    ContadorGeneracion = ContadorGeneracion + 1
    VectorRandom = VectorRandomHijo
    print("Generación #: " + str(ContadorGeneracion) + " " + ''.join(VectorRandomHijo) + " con puntuacion de: " + str(Puntuacion)) 
