/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package generics;

import java.util.ArrayList;


public class Generics {


    public static void main(String[] args) {

        
        Data_Access data = new Data_Access();
        ArrayList<Customer> Customer_Returns = data.Read_Customer();
        
        for (Customer client : Customer_Returns) {
            client.Data_Return();
        }
        ArrayList<Order> Order_Returns = data.Read_Order();
        for (Order ord : Order_Returns){
            ord.Data_Return();
        }
        
    }
    
}
