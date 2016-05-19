package herenciaempleado;
/**
 *
 * @author Estela Isabel Abreu
 */
public class Puesto extends Area {
int codigoPuesto;
private String descripPuesto;
Puesto datosPuesto;

Puesto(){
    super();
    this.datosPuesto = null;
}

Puesto(int codigoPuesto, String descripPuesto, int codigoArea, String descripArea, int codigoDepartamento, String descripDepartamento){
//super(codigoArea, descripArea, codigoDepartamento, descripDepartamento);
super(codigoArea, descripArea, codigoDepartamento, descripDepartamento, descripArea, descripArea, descripArea);
this.codigoPuesto = codigoPuesto;
this.descripPuesto = descripPuesto;
}

int getCodigoPuesto()
{
    return this.codigoPuesto;
}

String getDescripPuesto()
{
    return this.descripPuesto;    
}
    
}
