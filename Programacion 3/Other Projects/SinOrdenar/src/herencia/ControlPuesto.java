package herencia;
/**
 *
 * @author Estela Isabel Abreu
 */
public class ControlPuesto {
     Puesto tempPuesto;
    
    public static void main(String[] args)
    {
     ControlPuesto cp = new ControlPuesto();
     cp.insertPuesto(15, "RRHH", 100, "Soporte", 11, "DescripPuesto");
     cp.MostrarPuesto();
    }
    
    void insertPuesto(int codigoDepartamento, String descripDepartamento, int codigoArea, String descripArea, int codigoPuesto, String descripPuesto){
        if(tempPuesto!= null){
            tempPuesto = new Puesto(codigoArea, descripArea, codigoDepartamento, descripDepartamento, codigoPuesto, descripPuesto); //metodo sobrecarga
        }
        else
        {
            Puesto puesto = new Puesto(codigoArea, descripArea, codigoDepartamento, descripDepartamento, codigoPuesto, descripPuesto);
            puesto.datosPuesto = tempPuesto;
            tempPuesto = puesto;
        }
    }//Final Insert Area
    
    void MostrarPuesto(){
        Puesto puesto = tempPuesto;
        while(puesto != null){
        System.out.println(puesto.getCodigoArea() + " " + puesto.getDescripArea() + " " + puesto.getCodigoDepartamento() + " " + puesto.getDescripDepartamento() + " " + puesto.getCodigoPuesto() + " " + puesto.getDescripPuesto() + "\n");
        puesto = puesto.datosPuesto; 
        }
    }
    
}
