/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package ecosystemanimal;

import com.edu.yuxi.beans.Animal;
import com.edu.yuxi.beans.Factory;
import com.edu.yuxi.beans.FactoryAnimal;
import com.edu.yuxi.beans.Lion;
import java.util.Scanner;

/**
 *
 * @author jheison.cardona
 */
public class EcosystemAnimal {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        
//        FactoryAnimal factory = new FactoryAnimal();
//        Animal a=FactoryAnimal.getAnimal("Lion");
//        System.out.println(a);
        
        
        //switch
       // String animal[]= new String[2];
        
        
        
        Scanner teclado= new Scanner(System.in);
        System.out.println("Ingrese el animal");
        String animal= teclado.next();
        
        Factory fact = new Factory();
        Animal a=Factory.getAnimal(animal);
         System.out.println(a);
    }
    
}
