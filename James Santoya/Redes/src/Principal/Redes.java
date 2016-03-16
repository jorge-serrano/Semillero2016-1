/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Principal;

import Factory.FactoryRedes;
import Interface.InterfaceRedes;
import javax.swing.JOptionPane;

/**
 *
 * @author Yuxi
 */
public class Redes {

    public static void main(String[] args) {

        try {
            String saveItem = JOptionPane.showInputDialog("Ingrese La Red Social: ");
            FactoryRedes red = new FactoryRedes();
            InterfaceRedes r = FactoryRedes.getCreator(saveItem);
            r.conectar();
        } catch (Exception e) {
            JOptionPane.showMessageDialog(null, "Es Incorrecto!!!!", "Alerta", JOptionPane.ERROR_MESSAGE);
        }

    }

}
