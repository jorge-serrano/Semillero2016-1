# -*- coding: utf-8 -*-
import abc
from abc import ABCMeta

class Animal(object):
    __metaclass__ = ABCMeta
    @abc.abstractproperty
    def __init__(self):
        self.AnimalTye = None
        self.Name = None
    
    @abc.abstractmethod
    def get_Energy(self):
        return 
    def get_Animal(self):
        return self.Name
    
    def __str__(self):
        return "El animal es: ", str(self.get_Animal())
