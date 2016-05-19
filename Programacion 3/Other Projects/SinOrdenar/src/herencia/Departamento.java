package herencia;
/**
 *
 * @author Estela Isabel Abreu
 */
public class Departamento {
private int codigoDepartamento;
private String descripDepartamento;
Departamento datosDepartamento;

Departamento(){
    this.datosDepartamento = null;
}

Departamento(int codigoDepartamento, String descripDepartamento)
{
    this.codigoDepartamento = codigoDepartamento;
    this.descripDepartamento = descripDepartamento;
}

int getCodigoDepartamento(){
    return this.codigoDepartamento;
}

String getDescripDepartamento(){
    return this.descripDepartamento;
}

}
