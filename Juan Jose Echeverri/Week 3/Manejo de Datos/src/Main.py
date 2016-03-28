# -*- coding: utf-8 -*-
import Sender
from ExtractFiles import ReadTxt
def send_orders(vector_clients, vector_Orders):
    for i in range(len(vector_clients)): 
        Sender.Sender(vector_clients[i], vector_Orders.pop())
        print(i + 1, "Complete")
    print("Finalizado sin errores.")    
#CLIENTS -----------------------
vector_clients, clients_duplicate = ReadTxt("Clientes.txt", 1)
#Orders -----------------------
vector_orders, x = ReadTxt("Pedidos.txt", 0)
send_orders(vector_clients, vector_orders)
print(clients_duplicate, "Registro(s) duplicado(s) y descartados :D.")