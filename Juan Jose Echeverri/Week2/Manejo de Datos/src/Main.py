import Sender

def ReadTxt(archivo, procces):
    hF = open(archivo,"r") # arbre archivo
    tmp = hF.read() # lee contenido
    hF.close() # cierra
    l = []
    count = 0
    for elemento in tmp.split("\n"): # por cada linea    
        if elemento.split(",") in l and procces == 1:
            count = count + 1
        else:
            l.append(elemento.split(",")) # metemos en un
    return l, count

def EntregarPedidos(VectClientes, VectPedidos):
    for i in range(len(VectClientes)): 
        Sender.Sender(VectClientes[i], VectPedidos.pop())
        print(i + 1, "Complete")
    print("Finalizado sin errores.")

#CLIENTES -----------------------
VectClientes, duplicados = ReadTxt("Clientes.txt", 1)
#PEDIDOS -----------------------
VectPedidos, x = ReadTxt("Pedidos.txt", 0)

EntregarPedidos(VectClientes, VectPedidos)
print(duplicados, "Registro(s) duplicado(s) y descartados :D.")