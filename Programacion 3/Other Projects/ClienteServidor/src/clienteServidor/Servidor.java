package clienteServidor;

import java.io.*;
import java.net.*;
import java.rmi.server.SocketSecurityException;

public class Servidor {
 
	static final int puerto =5000;
	ServerSocket miServicio;
	String expresion,vector[];
	double op1,op2,resultado;
	DataInputStream Fentrada;
	DataOutputStream Fsalida;
	char elemento;
	//static boolean interruptor = true;
	
	public Servidor(){
		//if(interruptor==true){
		try {
			miServicio = new ServerSocket(puerto);
		} catch (IOException e) {
			// TODO Auto-generated catch block
			System.out.println(e.getMessage());
			//e.printStackTrace();
		}
		Socket socketServicio = null;
		
		
		try {
			System.out.println("Servidor: Escuchando");
			socketServicio = miServicio.accept();
		} catch (IOException e) {
			// TODO Auto-generated catch block
			System.out.println(e.getMessage());
		}
		 try{
			 Fsalida = new DataOutputStream(socketServicio.getOutputStream());
			 Fentrada = new DataInputStream(socketServicio.getInputStream());
			 System.out.println("Servidor: Se crearon las rutas");
			 
			 /*if(Fentrada.readUTF()=="Salir"){
				 interruptor=false;
				 
			 }else{*/
			 
			 recibirdatos();
			// }
			 socketServicio.close();
		 }catch (IOException e) {
				// TODO Auto-generated catch block
				System.out.println(e);
			}
	}
	//}
	private void  recibirdatos(){
		try{
			expresion = Fentrada.readUTF();
			vector = expresion.split(",");
			op1= Double.parseDouble(vector[0]);
			op2= Double.parseDouble(vector[1]);
			elemento=vector[2].charAt(0);
			
			switch(elemento){
			case'*':{
				resultado = op1*op2;
				break;
			}
			case'+':{
				resultado = op1+op2;
				break;
			}
			case'-':{
				resultado = op1-op2;
				break;
			}
			case'/':{
				resultado = op1*op2;
			}
			default:{
				resultado=0;
				break;}
			}
			
			Fsalida.writeDouble(resultado);
			System.out.println("Servidor: datos enviados");
		}
	catch (IOException e) {
		// TODO Auto-generated catch block
		System.out.println(e.getMessage());
	}
	}
	
	
	public static void main(String[] args) {
		// TODO Auto-generated method stub
		
         new Servidor();
		
		
	}

}
