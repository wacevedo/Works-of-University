/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package estudiante;

import java.io.*;
import java.io.IOException;

/**
 *
 * @author Estela Isabel Abreu
 */

public class ControlEstudiante {
    
Estudiante1 estMemoria;
File archivo = new File("C:\\Users\\Estela Isabel Abreu\\Documents\\NetBeansProjects\\Estudiante\\src\\estudiante\\notas.not");

void cargarEstudiante() throws IOException, ClassNotFoundException
{
    if (archivo.exists()==true)
    {
     FileInputStream archNota = new FileInputStream(archivo); //carga el archivo a memoria 
     ObjectInputStream nota = new ObjectInputStream(archNota); //convierte el archivo en un objeto para manipularlo (lo convierte a Byte)
     estMemoria = (Estudiante1) nota.readObject(); //guarda lo que tiene el objeto en la variable tipo estudiante.
     nota.close();
     archNota.close();     //cierro los dos archivos.
    }
    else
    {
        archivo.createNewFile();
    }
}

void insertarEstudiante(String matricula, String nombre, int calificacion)
{
    if (estMemoria == null)
    {
      estMemoria = new Estudiante1(matricula, nombre, calificacion); //si esta vacio, toma los parametros y los inserta en estMemoria
    }
    else
    {
        Estudiante1 estudiante = new Estudiante1(matricula, nombre, calificacion); //si esta lleno, hace el metodo de burbuja con la variable "estudiante" como temporal.
        estudiante.tempEstudiante1 = estMemoria;
        estMemoria = estudiante;
    }
}

void mostrarEstudiante()
{
    Estudiante1 estudiante = estMemoria;
    while(estudiante!=null)
    {
        System.out.println(estudiante.getMatricula() + " " + estudiante.getNombre() + " " + estudiante.getCalificacion());
        estudiante = estudiante.tempEstudiante1;
        
    }
}

void guardarEstudiante() throws FileNotFoundException, IOException
{
    FileOutputStream archNota = new FileOutputStream(archivo);
    ObjectOutputStream nota = new ObjectOutputStream(archNota);
    nota.writeObject(estMemoria); 
    nota.close();
    archNota.close();
}

}//final

