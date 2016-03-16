package Clases;

import java.awt.Desktop;
import java.net.URI;
import javax.swing.JOptionPane;
import javax.swing.JTextField;

/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
/**
 *
 * @author Yuxi
 */
public class Facebook implements Interface.InterfaceRedes {

    @Override
    public void conectar() {

        try {
            JOptionPane.showMessageDialog(null, "Bienvenido a Facebook!");
            Desktop.getDesktop().browse(new URI("https://www.facebook.com/"));
        } catch (Exception ex) {

        }
    }

}
