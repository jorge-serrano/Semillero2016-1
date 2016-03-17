package generics;

import java.util.HashMap;
import java.util.Map;
import java.util.Properties;
import java.util.Stack;
import javax.mail.Message;
import javax.mail.MessagingException;
import javax.mail.PasswordAuthentication;
import javax.mail.Session;
import javax.mail.Transport;
import javax.mail.internet.InternetAddress;
import javax.mail.internet.MimeMessage;

public class Email {

    Stack<Order> ordens = new Stack<>();
    public Map<String, String> clientes = new HashMap<>();

    public void SendEmail(Session session, String email, String msg) {
        try {
            Message message = new MimeMessage(session);
            message.setFrom(new InternetAddress("james.santoya@yuxipacific.com"));
            message.setRecipients(Message.RecipientType.TO,
                    InternetAddress.parse(email));
            message.setSubject("Your Order");
            message.setText(msg);
            Transport.send(message);
            System.out.println("Email Enviado!");
        } catch (MessagingException e) {
            throw new RuntimeException(e);
        }
    }

    public void Server() {
        Data_Access data = new Data_Access();
        clientes = data.LeerDataClients();

        Properties props = new Properties();
        props.put("mail.smtp.host", "smtp.gmail.com");
        props.put("mail.smtp.socketFactory.port", "465");
        props.put("mail.smtp.socketFactory.class",
                "javax.net.ssl.SSLSocketFactory");
        props.put("mail.smtp.auth", "true");
        props.put("mail.smtp.port", "587");

        Session session = Session.getDefaultInstance(props,
                new javax.mail.Authenticator() {
            protected PasswordAuthentication getPasswordAuthentication() {
                return new PasswordAuthentication("james.santoya@yuxipacific.com", "1110552175");
            }
        });
        for (Map.Entry<String, String> cliente : clientes.entrySet()) {
            String email = cliente.getKey();
            System.out.println("Cliente: " + cliente.getValue());
            ordens = data.LeerDataOrder();
            while (!ordens.empty()) {
                {
                    Order produc = ordens.pop();
                    System.out.println(email);
                    SendEmail(session, email, "Your " + produc.Product_Description + "  order was received");
                }

            }
        }
    }
}
