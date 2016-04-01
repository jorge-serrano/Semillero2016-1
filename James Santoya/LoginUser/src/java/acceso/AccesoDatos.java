/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package acceso;

import conexion.*;
import static conexion.Conexion.conectar;
import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;

/**
 *
 * @author Yuxi
 */
public class AccesoDatos extends Conexion {

    Connection con = conectar();

    public int buscar(String usuario, String pass) {
        
        int r = 0;

        try {
            PreparedStatement ps = null;
            ResultSet rs = null;
            ps = con.prepareStatement("exec BUSCAR ?,?");
            ps.setString(1, usuario);
            ps.setString(2, pass);
            rs = ps.executeQuery();
            if (rs.next() == true) {
                r = 1;
                con.close();
            }

        } catch (Exception e) {
            System.err.println(e.getMessage());
        }
        return r;
    }
    
}
