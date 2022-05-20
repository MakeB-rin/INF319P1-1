# -*- coding: utf-8 -*-
"""
Created on Mon May 16 20:03:00 2022

@author: MARCOS
"""

from pyswip import Prolog
prolog = Prolog()

#Padres 1ra Generacion 
#Primera Familia

prolog.assertz("padre(juan,julio)")
prolog.assertz("padre(juan,valeria)")
prolog.assertz("madre(carla,julio)")
prolog.assertz("madre(carla,valeria)")


#Segunda Familia

prolog.assertz("padre(alan,alejandro)")
prolog.assertz("padre(alan,pamela)")

prolog.assertz("madre(daniela,alejandro)")
prolog.assertz("madre(daniela,pamela)")


#Padres 2da Generacion 
#Tercera Familia

prolog.assertz("padre(julio,miguel)")
prolog.assertz("padre(julio,jose)")

prolog.assertz("madre(pamela,miguel)")
prolog.assertz("madre(pamela,jose)")


#abuelos 
prolog.assertz("abuelo(juan,miguel)")
prolog.assertz("abuelo(alan,miguel)")
prolog.assertz("abuela(carla,miguel)")
prolog.assertz("abuela(daniela,miguel)")

#nieto

prolog.assertz("nieto(miguel,juan)")
prolog.assertz("nieto(miguel,alan)")
prolog.assertz("nieto(miguel,carla)")
prolog.assertz("nieto(miguel,daniela)")
prolog.assertz("nieto(jose,juan)")
prolog.assertz("nieto(jose,alan)")
prolog.assertz("nieto(jose,carla)")
prolog.assertz("nieto(jose,daniela)")


#Tios

prolog.assertz("tia(valeria,miguel)")
prolog.assertz("tio(alejandro,miguel)")


#Padres

list(prolog.query("padre(juan,X)"))==[{"X":"valeria"},{"Y":"julio"}]
list(prolog.query("madre(carla,X)"))==[{"X":"valeria"},{"Y":"julio"}]

list(prolog.query("padre(alan,X)"))==[{"X":"pamela"},{"Y":"alejandro"}]
list(prolog.query("madre(daniela,X)"))==[{"X":"pamela"},{"Y":"alejandro"}]

#abuelos

list(prolog.query("abuelo(juan,X)"))==[{"X":"jose"},{"Y":"miguel"}]
list(prolog.query("abuela(carla,X)"))==[{"X":"jose"},{"Y":"miguel"}]

list(prolog.query("abuelo(alan,X)"))==[{"X":"jose"},{"Y":"miguel"}]
list(prolog.query("abuela(daniela,X)"))==[{"X":"jose"},{"Y":"miguel"}]

#nietos

list(prolog.query("nieto(miguel,X)"))==[{"X":"carla"},{"Y":"juan"}]
list(prolog.query("nieto(jose,X)"))==[{"X":"daniela"},{"Y":"alan"}]


#tios

list(prolog.query("tio(alejandro,X)"))==[{"X":"jose"},{"Y":"miguel"}]
list(prolog.query("tia(valeria,X)"))==[{"X":"jose"},{"Y":"miguel"}]





for elemento in prolog.query("padre(X,Y)"):
    print(elemento["X"], "es el padre de",elemento["Y"])
    
for elemento in prolog.query("madre(X,Y)"):
    print(elemento["X"], "es la madre de",elemento["Y"])   
    
#abuelos    

for elemento in prolog.query("abuelo(X,Y)"):
    print(elemento["X"], "es el abuelo de",elemento["Y"]) 
    
for elemento in prolog.query("abuela(X,Y)"):
    print(elemento["X"], "es la abuela de",elemento["Y"]) 
    
#nietos
for elemento in prolog.query("nieto(X,Y)"):
    print(elemento["X"], "es el nieto de",elemento["Y"]) 

    
#tios    
for elemento in prolog.query("tio(X,Y)"):
    print(elemento["X"], "es el tio de",elemento["Y"]) 
    
for elemento in prolog.query("tia(X,Y)"):
    print(elemento["X"], "es la tia de",elemento["Y"]) 
    







