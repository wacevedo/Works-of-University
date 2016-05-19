package clienteServidor;

import java.io.*;
import java.net.*;
import java.rmi.server.SocketSecurityException;
public class Cliente {

	static final String ip= "localhost";
	static final int puerto =5000;
	DataInputStream Fentrada;
	DataOutputStream Fsalida;
	byte[] buffer = new byte[1024];
	Socket socketCliente;
	public static BufferedReader stdin = new BufferedReader(new InputStreamReader(System.in));
	String expresion;
     public Cliente(){
    	 try {
			socketCliente = new Socket(ip,puerto);
			try{
				Fentrada = new DataInputStream(socketCliente.getInputStream());
				Fsalida = new DataOutputStream(socketCliente.getOutputStream());
				System.out.println("Cliente: se crearon las rutas");
				System.out.println("Ingrese la operacion");
				System.out.print(">");
				expresion = stdin.readLine();
				System.out.println("Expresion: "+ expresion);
				enviarDatos(expresion);
			}
			catch (IOException e) {
				// TODO Auto-generated catch block
				System.out.println(e);
			}
		} catch (IOException e) {
			// TODO Auto-generated catch block
			System.out.println(e.getMessage());
		}
     }
	
    private void enviarDatos(String expresion){
        try {
			Fsalida.writeUTF(expresion);
			System.out.println("Resultado= "+Fentrada.readDouble());
			
		} catch (IOException e) {
			// TODO Auto-generated catch block
			System.out.println(e.getMessage());
		}
    }
	public static void main(String[] args) {
		// TODO Auto-generated method stub
        new Cliente();
	}

}
