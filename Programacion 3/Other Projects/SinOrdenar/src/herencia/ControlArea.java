package herencia;
/**
 *
 * @author Estela Isabel Abreu
 */
public class ControlArea {
    Area tempArea;
    
    public static void main(String[] args)
    {
     ControlArea ca = new ControlArea();
     ca.insertArea(8, "Tecnología", 1455, "Soporte");
     ca.MostrarArea();
    }
    
    void insertArea(int codigoDepartamento, String descripDepartamento, int codigoArea, String descripArea){
        if(tempArea!= null){
            tempArea = new Area(codigoArea, descripArea, codigoDepartamento, descripDepartamento); //metodo sobrecarga
        }
        else
        {
            Area area = new Area(codigoArea, descripArea, codigoDepartamento, descripDepartamento);
            area.datosArea = tempArea;
            tempArea = area;
        }
    }//Final Insert Area
    
    void MostrarArea(){
        Area area = tempArea;
        while(area != null){
        System.out.println(area.getCodigoArea() + " " + area.getDescripArea() + " " + area.getCodigoDepartamento() + " " + area.getDescripDepartamento()+ "\n");
        area = area.datosArea; 
        }
    }
}
