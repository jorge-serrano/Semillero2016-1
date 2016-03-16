# -*- coding: utf-8 -*-
from Zebra import Zebra
from Chicken import Chicken
from Leon import Lion
from Tiger import Tiger
from Worm import Worm
from Eagle import Eagle
   
def get_classAnimal(name):
    if name == "ZEBRA":            
        return Zebra
    elif name == "CHIKEN":
        return Chicken
    elif name == "LEON":
        return Lion
    elif name == "TIGER":
        return Tiger
    elif name == "WORM":
        return Worm
    elif name == "EAGLE":
        return Eagle
    else:
        return 0