# -*- coding: utf-8 -*-
from AbsClassAnimal import Animal
from InterfacePredator import IPredator

class Eagle(Animal, IPredator):
    def __init__(self, name):
        print("Eagle")
        