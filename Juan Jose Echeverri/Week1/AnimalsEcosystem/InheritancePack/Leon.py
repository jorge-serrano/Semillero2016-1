# -*- coding: utf-8 -*-
from AbsClassAnimal import Animal
from InterfacePredator import IPredator

class Lion(Animal, IPredator):
    def __init__(self, name):
        print("leon")