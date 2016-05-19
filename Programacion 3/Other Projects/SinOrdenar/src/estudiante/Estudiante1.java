/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package estudiante;
import java.io.Serializable;

/**
 *
 * @author Estela Isabel Abreu
 */
public class Estudiante1 implements Serializable {
    
    private String matricula;
    private String nombre;
    private int calificacion;
    Estudiante1 tempEstudiante1;
    
    Estudiante1(String matricula, String nombre, int calificacion)
    {
        this.matricula = matricula;
        this.nombre = nombre;
        this.calificacion = calificacion;   
        this.tempEstudiante1 = null;
    }
    String getMatricula()
    {
        return this.matricula;
    }
    String getNombre()
    {
        return this.nombre;
    }
    int getCalificacion()
    {
        return this.calificacion;
    }
}

