package generics;

import generics.Customer;
import java.io.BufferedReader;
import java.nio.charset.Charset;
import java.nio.charset.StandardCharsets;
import java.nio.file.Files;
import java.nio.file.Path;
import java.nio.file.Paths;
import java.util.ArrayList;

public class Data_Access {

    public ArrayList<Customer> Read_Customer() {
        Path path = Paths.get("C:\\Users\\YUXI\\Desktop\\db_clientes.txt");
        Charset utf8 = StandardCharsets.UTF_8;
        String temporal;
        ArrayList<Customer> clients = new ArrayList<>();

        try (BufferedReader reader = Files.newBufferedReader(path, utf8)) {
            while ((temporal = reader.readLine()) != null) {
                String[] tmp_split = temporal.split(";");
                Customer client = new Customer(tmp_split[0], tmp_split[1]);
                    clients.add(client);

            }

        } catch (Exception e) {
//            e.printStackTrace();
        }

        return clients;
    }
    
    public ArrayList<Order> Read_Order() {
        Path path = Paths.get("C:\\Users\\YUXI\\Desktop\\db_pedidos.txt");
        Charset utf8 = StandardCharsets.UTF_8;
        String temporal1;
        ArrayList<Order> orders = new ArrayList<>();

        try (BufferedReader reader1 = Files.newBufferedReader(path, utf8)) {
            while ((temporal1 = reader1.readLine()) != null) {
               
                String[] tmp_split1 = temporal1.split(";");
                Order ord = new Order(tmp_split1[0], tmp_split1[1]);
                    orders.add(ord);

            }

        } catch (Exception e) {
//            e.printStackTrace();
        }

        return orders;
    }

}
