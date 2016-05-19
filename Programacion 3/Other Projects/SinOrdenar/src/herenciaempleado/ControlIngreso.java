/*package herenciaempleado;
/**
 *
 * @author Estela Isabel Abreu
 ********
public class ControlIngreso {
     Puesto tempIngreso;
    
    public static void main(String[] args)
    {
     ControlIngreso cin = new ControlIngreso();
     cin.insertIngreso(15, "RRHH", 100, "Tecnologia", 11, "DescripPuesto");
     cin.MostrarIngreso();
    }
    
    void insertIngreso(int codigoDepartamento, String descripDepartamento, int codigoArea, String descripArea, int codigoPuesto, String descripPuesto){
        if(tempIngreso!= null){
            tempIngreso = new Ingreso(codigoArea, descripArea, codigoDepartamento, descripDepartamento, codigoPuesto, descripPuesto); //metodo sobrecarga
        }
        else
        {
            Ingreso Ingreso = new Ingreso(codigoArea, descripArea, codigoDepartamento, descripDepartamento, codigoPuesto, descripPuesto);
           Ingreso.datosIngreso = tempIngreso;
            tempIngreso = Ingreso;
        }
    }//Final Insert Area
    
    void MostrarIngreso(){
        Ingreso Ingreso = tempIngreso;
        while(Ingreso != null){
        System.out.println(Ingreso.getCodigoArea() + " " + Ingreso.getDescripArea() + " " + Ingreso.getCodigoDepartamento() + " " + Ingreso.getDescripDepartamento() + " " + Ingreso.getCodigoPuesto() + " " + Ingreso.getDescripPuesto() + "\n");
        Ingreso = Ingreso.datosIngreso; 
        }
    }
    
}
*/
