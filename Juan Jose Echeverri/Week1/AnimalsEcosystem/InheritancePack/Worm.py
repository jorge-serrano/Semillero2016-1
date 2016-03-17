# -*- coding: utf-8 -*-
from AbsClassAnimal import Animal
from InterfacePrey import IPrey

class Worm(Animal, IPrey):
    def __init__(self, name):
        print("Worm")