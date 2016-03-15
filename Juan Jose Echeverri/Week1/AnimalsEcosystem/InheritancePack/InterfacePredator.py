# -*- coding: utf-8 -*-
import abc
from abc import ABCMeta

class IPredator(object):
    __metaclass__ = ABCMeta
    @abc.abstractmethod
    def Hunt(self):
        pass