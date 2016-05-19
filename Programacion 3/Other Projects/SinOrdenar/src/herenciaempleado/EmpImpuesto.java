package herenciaempleado;

import static herenciaempleado.IntEmpImpuesto.imp;
/**
 *
 * @author Estela Isabel Abreu
 */
public class EmpImpuesto extends Empleado implements IntEmpImpuesto{
    
    private double monto = 0.0;
    
    private int codigoIngreso;
    private String descripcionIngreso;
    private int impuesto;
    
    private int codigoEmpleado;
    private String descripEmpleado;

    private String codusr;
    private String Clave;
    private String Tipo;
    
    EmpImpuesto datosEmpImpuesto;
    
    EmpImpuesto(){
    super();
    imp.Impuesto();
    this.datosEmpImpuesto = null;
    }
    
    EmpImpuesto(int codigoEmpleado, String descripEmpleado, int codigoPuesto, String descripPuesto, int codigoArea, String descripArea, 
            int codigoDepartamento, String descripDepartamento, double monto, String codusr,String Clave,String Tipo){
        
        
    super(codigoEmpleado, descripEmpleado, codigoPuesto, descripPuesto, codigoArea, descripArea, codigoDepartamento, descripDepartamento);
    imp.Impuesto(codigoIngreso, descripcionIngreso, impuesto, codusr, Clave, Tipo);
    this.monto = monto; 
    this.codusr   =  codusr;
    this.Clave    =  Clave;
    this.Tipo     =  Tipo;
   
}    
    
}
