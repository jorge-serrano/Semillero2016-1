# -*- coding: utf-8 -*-
from AbsClassAnimal import Animal
from InterfacePrey import IPrey
from InterfacePredator import IPredator

class Tiger(Animal, IPredator, IPrey):
    def __init__(self, name):
        print("Tiger")