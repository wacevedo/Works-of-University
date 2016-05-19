/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package sockets;

import java.net.ServerSocket;
import java.io.*;
import java.net.*;
/**
 *
 * @author Estela Isabel Abreu
 */
public class Servidor {
    
    static final int puerto = 5000;
    ServerSocket miServicio;
    String expresion, vector[];
    double op1, op2, resultado;
    DataInputStream Fentrada;
    DataOutputStream Fsalida;
    char elemento;
    
    public Servidor(){
        
        try{
            miServicio = new ServerSocket(puerto);            
        }catch(IOException vError){
            System.out.println(vError.getMessage());
        }
        Socket socketServicio = null;
        
        try{
            System.out.println("Servidor: escuchando");
            socketServicio = miServicio.accept();            
        }catch(IOException vError){
            System.out.println(vError.getMessage());            
        }
        
        try{
            Fsalida = new DataOutputStream(socketServicio.getOutputStream());
            Fentrada = new DataInputStream(socketServicio.getInputStream());
            System.out.println("Servidor: se crearon las rutas");
            RecibirDatos();
            socketServicio.close();
        }catch(IOException vError){
            System.out.println(vError.getMessage());            
        }
    }//Fin metodo constructor

        private void RecibirDatos(){
            try{
                expresion = Fentrada.readUTF();
                vector = expresion.split(",");
                op1 = Double.parseDouble(vector[0]);                
                op2 = Double.parseDouble(vector[1]);
                elemento = vector[2].charAt(0);
                
                switch(elemento)
            {
                case '+':
                {
                  resultado = op1 + op2;
                  break;
                }
                case '-':
                {
                    resultado = op1 - op2;
                  break;
                }
                case '*':
                {
                  resultado = op1 * op2;
                  break;
                }
                case '/':
                {
                  resultado = op1 / op2;
                  break;
                }
                
                default: {
                    resultado = 0;
                    break;
                }       
                  
                }
                 Fsalida.writeDouble(resultado);                
                System.out.print("Servidor: enviando resultado"); 
            }catch(IOException vError){
                System.out.println(vError.getMessage());
            }
            
        }
    public static void main(String[] args) {
        new Servidor();
    }
    
    
}
