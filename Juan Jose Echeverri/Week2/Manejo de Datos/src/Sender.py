# -*- coding: utf-8 -*-
from email.mime.text import MIMEText
import smtplib
import random

def Sender(Destinatario, Producto): 
    # Establecemos conexion con el servidor smtp de gmail
    mailServer = smtplib.SMTP('smtp.gmail.com',587)
    mailServer.ehlo()
    mailServer.starttls()
    mailServer.ehlo()
    mailServer.login("juan.echeverri@yuxipacific.com","inadapta2!")
    #print(Producto)
    # Construimos el mensaje simple       
    mensaje = MIMEText("""    SU PEDIDO SE ENTREGARÁ EN LOS PRÓXIMOS DÍAS.
    
    DETALLE: 
    ||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||
    ||   PRODUCTO   ||||||   CANTIDAD   ||
    -------------------------------------------------------
          """  + Producto[0] + """                          """ + Producto[1] + """       
    ||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||
    
    y llegará en """ + str(random.randrange(1, 10, 1)) + """ días.
    Muchas gracias por usar nuestros servicios.
    
    
    YUXISENDS INC.© - 2016
    
    Mensaje generado automáticamente, por favor no responder.""")          
    mensaje['From']="juan.echeverri@yuxipacific.com"
    mensaje['To']=str(Destinatario[0] + ": " + Destinatario[1])
    mensaje['Subject']="PEDIDO !!!"
    
    # Envio del mensaje
    mailServer.sendmail("juan.echeverri@yuxipacific.com", str(Destinatario[1]), mensaje.as_string())
    return 1
