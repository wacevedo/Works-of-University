package herenciaempleado;
/**
 *
 * @author Estela Isabel Abreu
 */
public class Ingreso extends Empleado {
private int codigoIngreso;
private String descripIngreso;
private int ingreso;
Ingreso datosDeduccion;

Ingreso(){
    super();
    this.datosIngreso = null;
}

    public Deduccion(int codigoDeduccion, String descripDeduccion, int ingresoDeduccion, Deduccion datosDeduccion, int codigoEmpleado, String descripEmpleado, int codigoPuesto, String descripPuesto, int codigoArea, String descripArea, int codigoDepartamento, String descripDepartamento) {
        super(codigoEmpleado, descripEmpleado, codigoPuesto, descripPuesto, codigoArea, descripArea, codigoDepartamento, descripDepartamento);
        this.codigoDeduccion = codigoDeduccion;
        this.descripDeduccion = descripDeduccion;
        this.ingresoDeduccion = ingresoDeduccion;
        this.datosDeduccion = datosDeduccion;
    }

int getCodigoDeduccion()
{
    return this.codigoDeduccion;
}

@Override
String getDescripEmpleado()
{
    return this.descripDeduccion;    
}
        
}
