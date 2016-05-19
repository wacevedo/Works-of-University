package appServer;

import java.awt.EventQueue;

import javax.swing.JFrame;
import javax.swing.JOptionPane;
import javax.swing.JTextPane;

import java.awt.BorderLayout;

import javax.swing.JPanel;

import java.awt.GridBagLayout;

import javax.swing.JList;
import javax.swing.JButton;

import java.awt.GridBagConstraints;

import javax.swing.JLabel;

//import aplicacionservidor.FServidor;
//import aplicacionservidor.ProcesarPedido;

import java.awt.Font;
import java.awt.Insets;
import java.awt.event.ActionListener;
import java.awt.event.ActionEvent;
import java.io.IOException;
import java.net.ServerSocket;
import java.net.Socket;
import java.util.logging.Level;
import java.util.logging.Logger;
import javax.swing.JTable;

public class FormServer implements Runnable{
	
	static ServerSocket servidor;
    static final int puerto = 5000;     
    ProcesarPedido servicio;
    
	private JFrame frame;
	JList listLog = new JList();
	private JTable table;
	/**
	 * Launch the application.
	 */
	public static void main(String[] args) {
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					FormServer window = new FormServer();
					window.frame.setVisible(true);
				} catch (Exception e) {
					e.printStackTrace();
				}
			}
		});
	}

	/**
	 * Create the application.
	 */
	public FormServer() {
		initialize();
	}

	/**
	 * Initialize the contents of the frame.
	 */
	private void initialize() {
		frame = new JFrame();
		frame.setBounds(100, 100, 474, 456);
		frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		frame.getContentPane().setLayout(new BorderLayout(0, 0));
		
		JPanel panelBot = new JPanel();
		frame.getContentPane().add(panelBot, BorderLayout.SOUTH);
		
		JPanel panelTop = new JPanel();
		frame.getContentPane().add(panelTop, BorderLayout.NORTH);
		
		JPanel panelLeft = new JPanel();
		frame.getContentPane().add(panelLeft, BorderLayout.WEST);
		GridBagLayout gbl_panelLeft = new GridBagLayout();
		gbl_panelLeft.columnWidths = new int[]{0, 0};
		gbl_panelLeft.rowHeights = new int[]{0, 0, 0, 0, 0, 0};
		gbl_panelLeft.columnWeights = new double[]{0.0, Double.MIN_VALUE};
		gbl_panelLeft.rowWeights = new double[]{0.0, 0.0, 0.0, 0.0, 0.0, Double.MIN_VALUE};
		panelLeft.setLayout(gbl_panelLeft);
		
		JButton btnIniciar = new JButton("Iniciar");//Boton iniciar el servidor
		btnIniciar.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent arg0) {
				try  
		        {  
		           servidor = new ServerSocket(puerto);
		                  try {
		                 //this.jtexto.setText("esperando petición");
		                Socket cliente = servidor.accept();
		                System.out.println("form: solicitud recivida");
		                // this.jtexto.setText("\n NUEVA PETICION \n");
		                servicio = new ProcesarPedido(cliente); 
		                servicio.start();
		                //table.setModel(servicio.getTabla());
		            } catch (IOException ex) {
		                Logger.getLogger(FormServer.class.getName()).log(Level.SEVERE, null, ex);
		            }
		        // do{  
		          
		       // }while (true); 
		                
		        }  
		        catch (IOException ioEx)  
		        {  
		           JOptionPane.showMessageDialog(null, ioEx.toString(), "ERROR",JOptionPane.ERROR_MESSAGE);  
		           System.exit(1);  
		        } 	
			}
		});
		GridBagConstraints gbc_btnIniciar = new GridBagConstraints();
		gbc_btnIniciar.fill = GridBagConstraints.HORIZONTAL;
		gbc_btnIniciar.insets = new Insets(0, 0, 5, 0);
		gbc_btnIniciar.gridx = 0;
		gbc_btnIniciar.gridy = 0;
		panelLeft.add(btnIniciar, gbc_btnIniciar);
		
		JButton btnDetener = new JButton("Detener");
		btnDetener.addActionListener(new ActionListener() {
			@SuppressWarnings("deprecation")
			public void actionPerformed(ActionEvent arg0) {
				servicio.stop();
			}
		});
		GridBagConstraints gbc_btnDetener = new GridBagConstraints();
		gbc_btnDetener.fill = GridBagConstraints.HORIZONTAL;
		gbc_btnDetener.insets = new Insets(0, 0, 5, 0);
		gbc_btnDetener.gridx = 0;
		gbc_btnDetener.gridy = 1;
		panelLeft.add(btnDetener, gbc_btnDetener);
		
		JButton btnNewButton = new JButton("Guardar Log");
		GridBagConstraints gbc_btnNewButton = new GridBagConstraints();
		gbc_btnNewButton.fill = GridBagConstraints.HORIZONTAL;
		gbc_btnNewButton.insets = new Insets(0, 0, 5, 0);
		gbc_btnNewButton.gridx = 0;
		gbc_btnNewButton.gridy = 2;
		panelLeft.add(btnNewButton, gbc_btnNewButton);
		
		JButton btnNewButton_2 = new JButton("Limpiar Log");
		GridBagConstraints gbc_btnNewButton_2 = new GridBagConstraints();
		gbc_btnNewButton_2.insets = new Insets(0, 0, 5, 0);
		gbc_btnNewButton_2.fill = GridBagConstraints.HORIZONTAL;
		gbc_btnNewButton_2.gridx = 0;
		gbc_btnNewButton_2.gridy = 3;
		panelLeft.add(btnNewButton_2, gbc_btnNewButton_2);
		
		JPanel panelRight = new JPanel();
		frame.getContentPane().add(panelRight, BorderLayout.EAST);
		
		JPanel panelMid = new JPanel();
		frame.getContentPane().add(panelMid, BorderLayout.CENTER);
		panelMid.setLayout(null);
		
		
		listLog.setEnabled(false);
		listLog.setBounds(51, 57, 274, 140);
		panelMid.add(listLog);
		
		JLabel lblLog = new JLabel("Log");
		lblLog.setFont(new Font("Tahoma", Font.PLAIN, 18));
		lblLog.setBounds(51, 24, 53, 22);
		panelMid.add(lblLog);
		
		table = new JTable();
		table.setBounds(325, 382, -268, -160);
		panelMid.add(table);
	}

	@Override
	public void run() {
		// TODO Auto-generated method stub
		
	}
}
