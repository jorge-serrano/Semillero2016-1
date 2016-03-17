# -*- coding: utf-8 -*-
import random
from email.mime.text import MIMEText

def create_message(Order, Quantity, Name, Email):
    message = MIMEText("""    YOUR ORDER WILL BE DELIVERIED IN A FEW DAYS.
    
    DETAIL: 
    ||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||
    ||   PRODUCT    ||||||   Quantity   ||
    -------------------------------------------------------
          """  + Order + """                          """ + Quantity + """       
    ||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||
    
    AND WILL BE REACHED IN """ + str(random.randrange(1, 10, 1)) + """ DAYS.
    Thanks a lot for using our services.
    
    
    YUXISENDS INC.© - 2016
    
    Automatic message generator, please do not reply.""")
              
    message['From']="juan.echeverri@yuxipacific.com"
    message['To']=str(Name + ": " + Email)
    message['Subject']="PEDIDO !!!"
    
    return message.as_string()