package Clases;

import java.awt.Desktop;
import java.net.URI;
import javax.swing.JOptionPane;


public class Twitter implements Interface.InterfaceRedes {

    @Override
    public void conectar() {
        try {
            JOptionPane.showMessageDialog(null, "Bienvenido a Twitter!");
            Desktop.getDesktop().browse(new URI("https://twitter.com/login"));
        } catch (Exception ex) {

        }
    }

}
