package generics;

import java.util.Map;

public class Generics {

    public static void main(String[] args) {

        Email sendE = new Email();
        sendE.Server();

        Data_Access data = new Data_Access();
        Map<String, String> Retorno_Clientes = data.LeerDataClients();

    }

}
