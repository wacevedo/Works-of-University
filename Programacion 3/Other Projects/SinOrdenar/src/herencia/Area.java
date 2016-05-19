package herencia;

/**
 *
 * @author Estela Isabel Abreu
 */
public class Area extends Departamento {
private int codigoArea;
private String descripArea;
Area datosArea;

Area(){
    super();
    this.datosArea = null;
}

Area(int codigoArea, String descripArea, int codigoDepartamento, String descripDepartamento){
    super(codigoDepartamento, descripDepartamento);
    this.codigoArea = codigoArea;
    this.descripArea = descripArea;
}

int getCodigoArea()
{
    return this.codigoArea;
}

String getDescripArea(){
    return this.descripArea;
}
}
