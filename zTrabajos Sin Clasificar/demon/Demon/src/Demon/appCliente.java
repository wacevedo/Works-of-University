package Demon;

import java.awt.EventQueue;

import javax.swing.JFrame;
import javax.swing.JComboBox;

import java.awt.Dimension;
import java.awt.TextField;
import java.awt.Window.Type;
import java.awt.Font;

import javax.swing.JList;

import java.awt.Color;

import javax.swing.border.BevelBorder;
import javax.swing.border.LineBorder;
import javax.swing.border.EmptyBorder;
import javax.swing.UIManager;
import javax.swing.border.CompoundBorder;
import javax.swing.JButton;
import javax.swing.JProgressBar;
import javax.swing.JTable;
import javax.swing.table.DefaultTableModel;
import javax.swing.JScrollPane;
import javax.swing.JTextArea;
import javax.swing.JTextField;
import javax.swing.JToggleButton;
import javax.swing.JFormattedTextField;
import javax.swing.JSeparator;
import javax.swing.JSpinner;
import javax.swing.ScrollPaneConstants;
import javax.swing.SpinnerListModel;
import javax.swing.SpinnerDateModel;

import java.util.Date;
import java.util.Calendar;

import javax.swing.SpinnerNumberModel;
import javax.swing.DefaultComboBoxModel;
import javax.swing.JLabel;
import javax.swing.AbstractListModel;
import javax.swing.JPanel;

import java.awt.event.ItemListener;
import java.awt.event.ItemEvent;

import javax.swing.JCheckBox;

import java.awt.event.ActionListener;
import java.awt.event.ActionEvent;

import javax.swing.JScrollBar;

import java.awt.event.AdjustmentListener;
import java.awt.event.AdjustmentEvent;

import javax.swing.ListSelectionModel;

public class appCliente {

	private JFrame frmCliente;

	/*
	 *  0:0PM no se puede
	 *  Validar lo de 29 feb, años biciestos y demas
	  */
	//LOCALE
	String[] arregloReportes= new String[500];
	int cantReportes=0;
	JComboBox cmbAnio = new JComboBox();
	final JComboBox cmbMes = new JComboBox();
	final JComboBox cmbDia = new JComboBox();
	JSpinner spinMinutos = new JSpinner();
	JSpinner spinHoras = new JSpinner();
	JLabel lblNewLabel = new JLabel(":");
	JComboBox cmbAMPM = new JComboBox();
	JPanel panel = new JPanel();
	private final JPanel panel_2 = new JPanel();
	private final JButton btnSolicitarReporte = new JButton("Solicitar reporte");
	private final JLabel lblDate = new JLabel("DATE");
	private final JLabel lblTime = new JLabel("TIME");
	final JComboBox cmbSelects = new JComboBox();
	private final JButton btnHistorial = new JButton("Historial");
	JList listHistorialReporte = new JList();
	private final JScrollPane scrollPane = new JScrollPane(listHistorialReporte);
	private final JButton btnLimpiar = new JButton("Limpiar");
	
	//LOCALE
	/**
	 * Launch the application.
	 */
	public static void main(String[] args) {
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					appCliente window = new appCliente();
					window.frmCliente.setVisible(true);
				} catch (Exception e) {
					e.printStackTrace();
				}
			}
		});
	}

	/**
	 * Create the application.
	 */
	public appCliente() {
		initialize();
	}

	/**
	 * Initialize the contents of the frame.
	 */
	private void initialize() {
		frmCliente = new JFrame();
		frmCliente.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		frmCliente.setTitle("Client");
		frmCliente.setBounds(100, 100, 603, 404);
		frmCliente.getContentPane().setLayout(null);
		
		
        
		cmbSelects.setFont(new Font("Tahoma", Font.PLAIN, 16));
		cmbSelects.setToolTipText("12412512");
		cmbSelects.setModel(new DefaultComboBoxModel(new String[] {"Select 1", "Select 2", "Select 3"}));
		cmbSelects.setSelectedIndex(0);
		cmbSelects.setBounds(10, 11, 230, 22);
		frmCliente.getContentPane().add(cmbSelects);
		
		panel.setBounds(79, 127, 230, 84);
		frmCliente.getContentPane().add(panel);
		panel.setLayout(null);
		
		cmbAMPM.setBounds(156, 20, 59, 44);
		panel.add(cmbAMPM);
		cmbAMPM.setMaximumRowCount(2);
		cmbAMPM.setFont(new Font("Tahoma", Font.PLAIN, 16));
		cmbAMPM.setModel(new DefaultComboBoxModel(new String[] {"AM", "PM"}));
		cmbAMPM.setSelectedIndex(0);
		
		lblNewLabel.setBounds(66, -19, 46, 112);
		panel.add(lblNewLabel);
		lblNewLabel.setFont(new Font("Tahoma", Font.PLAIN, 50));
		
		spinHoras.setBounds(10, 20, 46, 44);
		panel.add(spinHoras);
		spinHoras.setFont(new Font("Tahoma", Font.PLAIN, 16));
		spinHoras.setModel(new SpinnerNumberModel(1, 1, 12, 1));
		
		spinMinutos.setBounds(87, 20, 46, 44);
		panel.add(spinMinutos);
		spinMinutos.setFont(new Font("Tahoma", Font.PLAIN, 16));
		spinMinutos.setModel(new SpinnerNumberModel(0, 0, 59, 1));
		panel_2.setLayout(null);
		panel_2.setBounds(79, 44, 283, 67);
		
		frmCliente.getContentPane().add(panel_2);
		cmbAnio.setBounds(204, 11, 67, 44);
		panel_2.add(cmbAnio);
		
		
		cmbAnio.setModel(new DefaultComboBoxModel(new String[] {"2014", "2015", "2016", "2017", "2018", "2019", "2020", "2021", "2022", "2023", "2024", "2025"}));
		cmbAnio.setSelectedIndex(0);
		cmbAnio.setMaximumRowCount(6);
		cmbAnio.setFont(new Font("Tahoma", Font.PLAIN, 16));
		cmbMes.setBounds(79, 11, 115, 44);
		panel_2.add(cmbMes);
		
		cmbMes.addItemListener(new ItemListener() { //cmbMes cambio, validacion anios biciestos
			public void itemStateChanged(ItemEvent e) {
				switch(cmbMes.getSelectedItem().toString())
				{
				case "February":
				{					
					if ((cmbAnio.getSelectedItem().toString() == "2016") || (cmbAnio.getSelectedItem().toString() == "2020") || (cmbAnio.getSelectedItem().toString() == "2024"))
					{						
						cmbDia.setModel(new DefaultComboBoxModel(new String[] {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29"}));
					}
					else
					{
						cmbDia.setModel(new DefaultComboBoxModel(new String[] {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28"}));
					}
					break;
				}//end case February
				
				case "September":
				{
					cmbDia.setModel(new DefaultComboBoxModel(new String[] {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30"}));
					break;
				}//end case Septiembre
				
				case "April":
				{
					cmbDia.setModel(new DefaultComboBoxModel(new String[] {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30"}));
					break;
				}//end case Abril
				
				case "June":
				{
					cmbDia.setModel(new DefaultComboBoxModel(new String[] {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30"}));
					break;
				}//end case Junio
				
				case "November":
				{
					cmbDia.setModel(new DefaultComboBoxModel(new String[] {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30"}));
					break;
				}//end case Noviembre
				
				}//end switch
				
			}
		});
		cmbMes.setModel(new DefaultComboBoxModel(new String[] {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"}));
		cmbMes.setSelectedIndex(0);
		cmbMes.setMaximumRowCount(6);
		cmbMes.setFont(new Font("Tahoma", Font.PLAIN, 16));
		cmbDia.setBounds(10, 11, 59, 44);
		panel_2.add(cmbDia);
		
		cmbDia.setModel(new DefaultComboBoxModel(new String[] {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31"}));
		cmbDia.setSelectedIndex(0);
		cmbDia.setMaximumRowCount(6);
		cmbDia.setFont(new Font("Tahoma", Font.PLAIN, 16));
		btnSolicitarReporte.addActionListener(new ActionListener() {
			//Boton Solicitar Reporte
			public void actionPerformed(ActionEvent arg0) {									
				arregloReportes[cantReportes] = "Reporte: " + cmbSelects.getSelectedItem().toString() +" para la fecha: " + cmbDia.getSelectedItem().toString() + "/" + cmbMes.getSelectedItem().toString() + "/" + cmbAnio.getSelectedItem().toString() + " y la hora: " + spinHoras.getValue().toString() +":"+spinMinutos.getValue().toString() + " " + cmbAMPM.getSelectedItem().toString();
				cantReportes++;
				listHistorialReporte.setModel(new DefaultComboBoxModel(arregloReportes));
				Cliente a = new Cliente(spinMinutos.getValue().toString(), spinHoras.getValue().toString(), cmbDia.getSelectedItem().toString(), cmbMes.getSelectedItem().toString(), cmbAnio.getSelectedItem().toString(), cmbAMPM.getSelectedItem().toString(), cmbSelects.getSelectedIndex());
				//MetodoPdf = a.iniciar();	
				
			}
		});
		btnSolicitarReporte.setFont(new Font("Tahoma", Font.PLAIN, 17));
		btnSolicitarReporte.setBounds(372, 90, 204, 55);
		
		frmCliente.getContentPane().add(btnSolicitarReporte);
		lblDate.setFont(new Font("Tahoma", Font.PLAIN, 17));
		lblDate.setBounds(10, 73, 46, 14);
		
		frmCliente.getContentPane().add(lblDate);
		lblTime.setFont(new Font("Tahoma", Font.PLAIN, 17));
		lblTime.setBounds(10, 165, 46, 14);
		
		frmCliente.getContentPane().add(lblTime);
		scrollPane.setHorizontalScrollBarPolicy(ScrollPaneConstants.HORIZONTAL_SCROLLBAR_NEVER);
        
		scrollPane.setBounds(10, 222, 562, 132);
		frmCliente.getContentPane().add(scrollPane);
		btnHistorial.addActionListener(new ActionListener() {
			
			public void actionPerformed(ActionEvent arg0) 
			{
				if (scrollPane.isVisible() == true){
					scrollPane.setVisible(false);
				}else if (scrollPane.isVisible() == false){
					scrollPane.setVisible(true);
				}				
			}
		});
		btnHistorial.setFont(new Font("Tahoma", Font.PLAIN, 17));
		btnHistorial.setBounds(372, 156, 102, 55);
		
		frmCliente.getContentPane().add(btnHistorial);
		listHistorialReporte.setVisibleRowCount(0);
		listHistorialReporte.setValueIsAdjusting(true);
		listHistorialReporte.setSelectionMode(ListSelectionModel.SINGLE_INTERVAL_SELECTION);
		
		
		listHistorialReporte.setModel(new AbstractListModel() {
			String[] values = new String[] {};
			public int getSize() {
				return values.length;
			}
			public Object getElementAt(int index) {
				return values[index];
			}
		});
		listHistorialReporte.setSelectedIndex(0);
		listHistorialReporte.setFont(new Font("Tahoma", Font.PLAIN, 10));
		listHistorialReporte.setBorder(new BevelBorder(BevelBorder.LOWERED, null, null, null, null));
		listHistorialReporte.setBackground(Color.WHITE);
		listHistorialReporte.setBounds(460, 407, 112, 89);
		btnLimpiar.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent arg0) {
				arregloReportes = new String[500];
				listHistorialReporte.setModel(new DefaultComboBoxModel(arregloReportes));
				cantReportes = 0;
				
			}
		});
		btnLimpiar.setFont(new Font("Tahoma", Font.PLAIN, 17));
		btnLimpiar.setBounds(474, 156, 102, 55);
		
		frmCliente.getContentPane().add(btnLimpiar);
		
		
		
	}
}
