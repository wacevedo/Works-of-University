/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package herenciaempleado;

/**
 *
 * @author Estela Isabel Abreu
 */
public class EmpleadoIngreso extends Empleado implements IntEmpIngreso{
    
    private double monto = 0.0;
    
    private int codigoIngreso;
    private String descripcionIngreso;
    private int ingreso;
    
    private int codigoEmpleado;
    private String descripEmpleado;

    private String codusr;
    private String Clave;
    private String Tipo;
    
    EmpleadoIngreso datosEmpIngreso;
    
    EmpleadoIngreso(){
    super();
    ing.Ingreso();
    this.datosEmpIngreso = null;
    }
    
    EmpleadoIngreso(int codigoEmpleado, String descripEmpleado, int codigoPuesto, String descripPuesto, int codigoArea, String descripArea, int codigoDepartamento, String descripDepartamento, double monto, String codusr,String Clave,String Tipo){
    super(codigoEmpleado, descripEmpleado, codigoPuesto, descripPuesto, codigoArea, descripArea, codigoDepartamento, descripDepartamento);
    ing.Ingreso(codigoIngreso, descripcionIngreso, ingreso, codusr, Clave, Tipo);
    this.monto = monto; 
    this.codusr   =  codusr;
    this.Clave    =  Clave;
    this.Tipo     =  Tipo;
   
}
    
}

