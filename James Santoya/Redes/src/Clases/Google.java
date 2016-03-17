package Clases;

import java.awt.Desktop;
import java.net.URI;
import javax.swing.JOptionPane;

public class Google implements Interface.InterfaceRedes {

    @Override
    public void conectar() {
        try {
            JOptionPane.showMessageDialog(null, "Bienvenido a Google+!");
            Desktop.getDesktop().browse(new URI("https://plus.google.com/"));
        } catch (Exception ex) {

        }
    }

}
