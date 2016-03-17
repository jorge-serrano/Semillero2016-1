/* * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.edu.yuxi.beans;

import java.util.Scanner;

/**
 *
 * @author jheison.cardona
 */
public class Factory {
    
 
        
        
   
  
     public static Animal getAnimal(String animal){  
       
       
      
         
        switch(animal){
           
            case  "Lion":
            return new Lion();
          
            case  "Snake":
            return new Snake();
           
           
        }
    return null;
     }
    
}
