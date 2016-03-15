# -*- coding: utf-8 -*-
import Factory
if __name__ == '__main__':
    string = str(input("Please type the animal's name: "))
    ResultAnimal = Factory.get_classAnimal(string.upper())
    print(ResultAnimal)