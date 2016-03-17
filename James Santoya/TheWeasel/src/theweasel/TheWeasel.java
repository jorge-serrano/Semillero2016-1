/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package theweasel;

import java.util.Random;

/**
 *
 * @author emmanuel.gaviria
 */
public class TheWeasel {

    private static final Random rnd =new Random();
    private static final String chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ ";
    private final String destino;
    private String origen;
    
    public TheWeasel(String origen, String destino){
        this.origen=origen;
        this.destino = destino;
        
    }
    
    public static String fraseCambiante(String frase){
        StringBuilder sb = new StringBuilder();
        for (char c : frase.toCharArray()) {
            if (rnd.nextInt(100/5)==0) {
                sb.append(charAlAzar());
            }
            else{
                sb.append(c);
            }
        }
        return sb.toString();
    }
    
    public static char charAlAzar(){
        return chars.charAt(rnd.nextInt(chars.length()));
    }
    
    public String generarMejorMuestra(int muestras){
        int mejorPuntaje=0;
        String mejorMuestra=null;
        for (int i = 0; i < muestras; i++) {
            int puntaje=0;
            String fraseMuestra=fraseCambiante(origen);
            for (int j=0;j< fraseMuestra.length();j++) {
                if(destino.charAt(j)== fraseMuestra.charAt(j)){
                    puntaje++;
                }
            }
            if (puntaje>mejorPuntaje) {
                mejorPuntaje=puntaje;
                mejorMuestra=fraseMuestra;
            }
            if (puntaje==destino.length()) {
                break;
            }
        }
        return origen=mejorMuestra;
    }
    
    public static void main(String[] args) {
        String fraseFinal = "METHINKS IT IS LIKE A WEASEL";
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < fraseFinal.length(); i++) {
            sb.append(charAlAzar());
        }
        String frase=sb.toString();
        System.out.println("  "+frase);
        TheWeasel wsl=new TheWeasel(frase,fraseFinal);
        
        int count = 0;
        while (!fraseFinal.equals(frase)) {            
            frase=wsl.generarMejorMuestra(100);
            System.out.println(++count + " " + frase);
        }
    }
        
}