package generics;

import java.io.BufferedReader;
import java.nio.charset.Charset;
import java.nio.charset.StandardCharsets;
import java.nio.file.Files;
import java.nio.file.Path;
import java.nio.file.Paths;
import java.util.HashMap;
import java.util.Map;
import java.util.Stack;

public class Data_Access {
    Map<String, String> clientes = new HashMap<>();
    public Map<String, String> LeerDataClients() {
        Path path = Paths.get("C:\\Users\\Yuxi\\Desktop\\db_clientes.txt");
        Charset utf8 = StandardCharsets.UTF_8;
        String temporal;

        try (BufferedReader reader = Files.newBufferedReader(path, utf8)) {
            while ((temporal = reader.readLine()) != null) {
                String[] tmp_split = temporal.split(",");
                Customer cliente = new Customer(tmp_split[0], tmp_split[1]);
                clientes.put(cliente.email, cliente.name);
            }

        } catch (Exception e) {           
        }
        return clientes;
    }
    String email, name;
    public Map mostrarDatos() {
        for (Map.Entry<String, String> entry : clientes.entrySet()) {
            System.out.println(entry.getKey() + " " + entry.getValue());
        }
        return clientes;
    }

    public Stack<Order> LeerDataOrder() {
        Path path = Paths.get("C:\\Users\\Yuxi\\Desktop\\db_ordenes.txt");
        Charset utf8 = StandardCharsets.UTF_8;
        String temporal;
        Stack<Order> ordens = new Stack<>();

        try (BufferedReader reader = Files.newBufferedReader(path, utf8)) {
            while ((temporal = reader.readLine()) != null) {
                String[] tm = temporal.split(",");
                Order orden = new Order(tm[0], tm[1]);
                ordens.push(orden);
            }
        } catch (Exception e) {
        }
        return ordens;
    }
}
