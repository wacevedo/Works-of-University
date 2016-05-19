package herenciaempleado;

import static herenciaempleado.IntEmpDeduccion.ded;
/**
 *
 * @author Estela Isabel Abreu
 */
public class EmpDeduccion extends Empleado implements IntEmpDeduccion{
    
    private double monto = 0.0;
    
    private int codigoIngreso;
    private String descripcionIngreso;
    private int deduccion;
    
    private int codigoEmpleado;
    private String descripEmpleado;

    private String codusr;
    private String Clave;
    private String Tipo;
    
    EmpDeduccion datosEmpDeduccion;
    
    EmpDeduccion(){  
    super();
    ded.Deduccion();
    this.datosEmpDeduccion = null;
    }
    
    EmpDeduccion(int codigoEmpleado, String descripEmpleado, int codigoPuesto, String descripPuesto, int codigoArea, String descripArea, 
            int codigoDepartamento, String descripDepartamento, double monto, String codusr,String Clave,String Tipo){
        
        
   super(codigoEmpleado, descripEmpleado, codigoPuesto, descripPuesto, codigoArea, descripArea, codigoDepartamento, descripDepartamento);
    ded.Deduccion(codigoIngreso, descripcionIngreso, deduccion, codusr, Clave, Tipo);
    this.monto = monto; 
    this.codusr   =  codusr;
    this.Clave    =  Clave;
    this.Tipo     =  Tipo;
   
}    
    
}