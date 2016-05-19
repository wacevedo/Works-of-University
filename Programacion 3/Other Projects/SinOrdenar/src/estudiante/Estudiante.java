/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package estudiante;

import java.io.IOException;
import java.util.Scanner;

/**
 *
 * @author Estela Isabel Abreu
 */
public class Estudiante {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) throws IOException, ClassNotFoundException {
        Scanner en = new Scanner(System.in);
        ControlEstudiante cest = new ControlEstudiante();
        cest.cargarEstudiante();
        int seleccione = 13;
        while(seleccione != 3)
        {   
            mostrarMenu();
            seleccione = en.nextInt();
            switch(seleccione)
            {
                
                case 1:
                    System.out.println("Inserte matrícula, nombre y calificación");
                    cest.insertarEstudiante(en.next(), en.next(), en.nextInt());
                    break;
                case 2:
                    cest.mostrarEstudiante();
                    break;
                case 3:
                    cest.guardarEstudiante();
                    break;
            }
            
        }
    }
        static void mostrarMenu()
        {
            System.out.println("-------Menú-------");
            System.out.println("1. Insertar");
            System.out.println("2. Mostrar");
            System.out.println("3. Guardar y Salir");
            System.out.print("Opción: ");
        }
    
}
