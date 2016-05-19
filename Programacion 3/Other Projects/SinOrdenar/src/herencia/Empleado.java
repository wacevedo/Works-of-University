package herencia;
/**
 *
 * @author Estela Isabel Abreu
 */
public class Empleado extends Puesto {
private int codigoEmpleado;
private String descripEmpleado;
Empleado datosEmpleado;

Empleado(){
    super();
    this.datosEmpleado = null;
}

Empleado(int codigoEmpleado, String descripEmpleado, int codigoPuesto, String descripPuesto, int codigoArea, String descripArea, int codigoDepartamento, String descripDepartamento){
super(codigoPuesto, descripPuesto, codigoArea, descripArea, codigoDepartamento, descripDepartamento);
    this.codigoEmpleado = codigoEmpleado;
    this.descripEmpleado = descripEmpleado;
}

int getCodigoEmpleado()
{
    return this.codigoEmpleado;
}

String getDescripEmpleado()
{
    return this.descripEmpleado;    
}
        
}
