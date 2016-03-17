# -*- coding: utf-8 -*-
import smtplib
from Message import create_message

def Sender(Destinatario, Producto):
    mailServer = smtplib.SMTP('smtp.gmail.com',587)
    mailServer.ehlo()
    mailServer.starttls()
    mailServer.ehlo()
    mailServer.login("juan.echeverri@yuxipacific.com","******")    
    menssagesender = str(create_message(Producto[0], Producto[1], Destinatario[0], Destinatario[1]))    
    mailServer.sendmail("juan.echeverri@yuxipacific.com", str(Destinatario[1]), menssagesender)
    return 1
