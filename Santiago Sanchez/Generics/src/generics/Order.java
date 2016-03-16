
package generics;

class Order {
    
    
    public String Product_Description,  Quantity;

    public String getQuantity() {
        return Quantity;
    }

    public void setQuantity(String Quantity) {
        this.Quantity = Quantity;
    }

    public String getProduct_Description() {
        return Product_Description;
    }

    public void setProduct_Description(String Product_Description) {
        this.Product_Description = Product_Description;
    }
    
    public void Data_Return() {
        System.out.println("Quantity: " + Quantity + "   Description: " + Product_Description);
    }
    
        public Order(String Quantity, String Product_Description) {

        this.Quantity=Quantity;
        this.Product_Description = Product_Description;
    }
    
    
    
    
    
}
