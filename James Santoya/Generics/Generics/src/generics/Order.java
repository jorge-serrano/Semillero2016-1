package generics;

class Order {

    public String Quantity;
    public String Product_Description;

    public Order() {
    }

    public Order(String Quantity, String Product_Description) {
        this.Quantity = Quantity;
        this.Product_Description = Product_Description;
    }

    public void RetornarDatos() {
        System.out.println("Cantidad : " + Quantity + "   Producto : " + Product_Description);
    }

}
