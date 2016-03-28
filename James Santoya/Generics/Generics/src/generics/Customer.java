package generics;

public class Customer {

    Customer() {

    }

    public int id;
    public String name, email;

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public String getEmail() {
        return email;
    }

    public void setEmail(String email) {
        this.email = email;
    }

    public void RetornarDatos() {
        System.out.println("Email: " + email + "   Nombre:" + name);
    }

    public Customer(String email, String nombre) {
        super();
        this.email = email;
        this.name = nombre;

    }

}
