package herenciaempleado;

import static herenciaempleado.IntEmpIngreso.ing;
/**
 *
 * @author Estela Isabel Abreu
 */
public class EmpIngreso extends Empleado implements IntEmpIngreso{
    
    private double monto = 0.0;
    
    private int codigoIngreso;
    private String descripcionIngreso;
    private int ingreso;
    
    private int codigoEmpleado;
    private String descripEmpleado;

    private String codusr;
    private String Clave;
    private String Tipo;
    
    EmpIngreso datosEmpIngreso;
    
    EmpIngreso(){
    super();
    ing.Ingreso();
    this.datosEmpIngreso = null;
    }
    
    EmpIngreso(int codigoEmpleado, String descripEmpleado, int codigoPuesto, String descripPuesto, int codigoArea, String descripArea, 
            int codigoDepartamento, String descripDepartamento, double monto, String codusr,String Clave,String Tipo){
        
        
    super(codigoEmpleado, descripEmpleado, codigoPuesto, descripPuesto, codigoArea, descripArea, codigoDepartamento, descripDepartamento);
    ing.Ingreso(codigoIngreso, descripcionIngreso, ingreso, codusr, Clave, Tipo);
    this.monto = monto; 
    this.codusr   =  codusr;
    this.Clave    =  Clave;
    this.Tipo     =  Tipo;
   
}    
    
}
