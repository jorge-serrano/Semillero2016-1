# -*- coding: utf-8 -*-
import abc
from abc import ABCMeta

class IPrey(object):
    __metaclass__ = ABCMeta
    @abc.abstractmethod
    def Run(self):
        pass 