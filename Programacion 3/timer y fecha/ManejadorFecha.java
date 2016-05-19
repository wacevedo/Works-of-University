package clienteServidor;

import java.text.SimpleDateFormat;
//import java.util.Calendar;
import java.util.Date;
//import java.util.GregorianCalendar;
import java.util.Locale;
import java.text.DateFormat;
import java.text.ParseException;

public class ManejadorFecha {

	
	//Metodo usado para obtener la fecha actual
    //@return Retorna un <b>STRING</b> con la fecha actual formato "dd-MM-yyyy"
    public static String getFechaActual() {
        Date ahora = new Date();
        SimpleDateFormat formateador = new SimpleDateFormat("dd-MM-yyyy");
        return formateador.format(ahora);
    }
    
    //Metodo usado para obtener la fecha Y hora actual
    //@return Retorna un <b>DATE</b> con la fecha y hora actual 
    public static Date getFechaYHoraActual() {
        Date ahora = new Date();        
        return ahora;
    }
    

    //Metodo usado para obtener la hora actual del sistema
    //@return Retorna un <b>STRING</b> con la hora actual formato "hh:mm:ss"
    public static String getHoraActual() {
        Date ahora = new Date();
        SimpleDateFormat formateador = new SimpleDateFormat("hh:mm:ss");
        return formateador.format(ahora);
    }
    
    //Diferencias entre dos fechas
    //@param fechaInicial La fecha de inicio
    //@param fechaFinal  La fecha de fin
    //@return Retorna el numero de dias entre dos fechas
    public static synchronized int diferenciasDeFechasADias(Date fechaInicial, Date fechaFinal) {

        DateFormat df = DateFormat.getDateInstance(DateFormat.MEDIUM);
        String fechaInicioString = df.format(fechaInicial);
        try {
            fechaInicial = df.parse(fechaInicioString);
        } catch (ParseException ex) {
        }

        String fechaFinalString = df.format(fechaFinal);
        try {
            fechaFinal = df.parse(fechaFinalString);
        } catch (ParseException ex) {
        }

        long fechaInicialMs = fechaInicial.getTime();
        long fechaFinalMs = fechaFinal.getTime();
        long diferencia = fechaFinalMs - fechaInicialMs;
        double dias = Math.floor(diferencia / (1000 * 60 * 60 * 24));
        return ((int) dias);
    }
    
    //Diferencias entre dos fechas
    //@param fechaInicial La fecha de inicio
    //@param fechaFinal  La fecha de fin
    //@return Retorna el numero de seg entre dos fechas
    public static synchronized int diferenciasDeFechaASeg(Date fechaInicial, Date fechaFinal) {

        /*DateFormat df = DateFormat.getDateInstance(DateFormat.LONG);
        String fechaInicioString = df.format(fechaInicial);
        try {
            fechaInicial = df.parse(fechaInicioString);
        } catch (ParseException ex) {
        }

        String fechaFinalString = df.format(fechaFinal);
        try {
            fechaFinal = df.parse(fechaFinalString);
        } catch (ParseException ex) {
        }*/
        long fechaInicialMs = fechaInicial.getTime();
        long fechaFinalMs = fechaFinal.getTime();
        long diferencia = fechaFinalMs - fechaInicialMs;
        double seg = Math.floor(diferencia / (1000));
        return ((int) seg);
    }
    
    //Conversor de fecha
    /*G   Era designator       Text               AD
y   Year                 Year               1996; 96
M   Month in year        Month              July; Jul; 07
w   Week in year         Number             27
W   Week in month        Number             2
D   Day in year          Number             189
d   Day in month         Number             10
F   Day of week in month Number             2
E   Day in week          Text               Tuesday; Tue
u   Day number of week   Number             1
a   Am/pm marker         Text               PM
H   Hour in day (0-23)   Number             0
k   Hour in day (1-24)   Number             24
K   Hour in am/pm (0-11) Number             0
h   Hour in am/pm (1-12) Number             12
m   Minute in hour       Number             30
s   Second in minute     Number             55
S   Millisecond          Number             978
z   Time zone            General time zone  Pacific Standard Time; PST; GMT-08:00
Z   Time zone            RFC 822 time zone  -0800
X   Time zone            ISO 8601 time zone -08; -0800; -08:00*/
    //
    public Date ConvertToDate7(String string) throws ParseException
    {
    //String string = "January 2, 2010";
    DateFormat format = new SimpleDateFormat("MMMM d, yyyy, hh, mm, aa", Locale.ENGLISH);
    Date date = format.parse(string);
    return date;
    }
    
    
    /*
    public Date ConvertToDate8() throws ParseException
    {
    String string = "January 2, 2010";
    DateTimeFormatter formatter = DateTimeFormatter.ofPattern("MMMM d, yyyy", Locale.ENGLISH);
    LocalDate date = LocalDate.parse(string, formatter);
    return date;
    }*/
    
    
    
    
    public static void main(String args[]) throws ParseException {
    	ManejadorFecha mf = new ManejadorFecha();
    	
    	//Date fechaInicial = mf.ConvertToDate7("January 2, 2010, 02, 00, AM");
    	Date fechaInicial = mf.getFechaYHoraActual();
    	Date fechaFinal = mf.ConvertToDate7("January 1, 2015, 05, 01, PM");
    	//System.out.println(mf.getFechaActual());
    	//System.out.println(mf.getFechaYHoraActual());
    	System.out.println(fechaInicial);
    	System.out.println(fechaFinal);
    	System.out.println(mf.diferenciasDeFechasADias(fechaInicial, fechaFinal));
    	System.out.println(mf.diferenciasDeFechaASeg(fechaInicial, fechaFinal));
    	System.out.println();
    }
}
