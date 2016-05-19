/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package grafic;

import java.awt.FlowLayout;
import javax.swing.*;

/**
 *
 * @author Estela Isabel Abreu
 */
public class Grafic extends JFrame{

    JButton nuevo;
    JLabel descr;
    JTextField codigo;
    JTextField codigo1;
 
   /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
        Grafic ventana = new Grafic();
        ventana.setTitle("Prueba");
    }
    public Grafic(){
        nuevo = new JButton("Aceptar");
        descr = new JLabel("Codigo");
        codigo = new JTextField(12);        
        codigo1 = new JTextField(12);
        setLayout(new FlowLayout());
        
        getContentPane().add(descr);
        getContentPane().add(codigo);
        getContentPane().add(nuevo);
        getContentPane().add(codigo1);
        
        setSize(350,200);
        setVisible(true);
    }
    
}
