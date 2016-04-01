package beans;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.SQLException;
import javax.swing.JOptionPane;

public class connect {

    static String url = "jdbc:sqlserver://PRACT-EMMANUELG\\SQLEXPRESS:1433;databaseName=ICommerce;user=emmanuel123;password=1234";
    String driver = "com.microsoft.sqlserver.jdbc.SQLServerDriver";
    Connection con = null;

    public connect() {
        try {
            Class.forName(driver);
            con = DriverManager.getConnection(url);
            if (con != null) {
                JOptionPane.showMessageDialog(null, "Conexion correcta a SQL SERVER", "Conexion SQL", JOptionPane.INFORMATION_MESSAGE);
            }

        } catch (SQLException | ClassNotFoundException e) {

            JOptionPane.showMessageDialog(null, e);
                    }
                }
    
    public Connection getConnection() {
        return con;
    }

    public void Desconectar() {
        con = null;
        if (con != null) {
            JOptionPane.showMessageDialog(null, "No se pudo cerrar la conexion a la BD");

        }
    }

}
