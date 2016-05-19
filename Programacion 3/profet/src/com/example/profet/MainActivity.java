package com.example.profet;

import java.util.ArrayList;
import java.util.List;

import android.app.Activity;
import android.content.ContentValues;
import android.content.Intent;
import android.database.Cursor;
import android.database.sqlite.SQLiteDatabase;
import android.os.Bundle;
import android.view.View;
import android.widget.AdapterView;
import android.widget.AdapterView.OnItemSelectedListener;
import android.widget.ArrayAdapter;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Spinner;
import android.widget.TextView;
import android.widget.Toast;

public class MainActivity extends Activity implements OnItemSelectedListener{
	Button btnIngresar;
	Spinner spCategoria,spEspecificar;
	TextView texto1;
	EditText usuario;
	ArrayAdapter<String> aaCategoria,aaProfetas,aaSalmos,aaClear;
	
	String[] opCategoria = new String[]{"Salmos","Profetas","La ley"};
	String[] opProfetas= new String[]{"Josué","Jueces","Isaías","Jeremías","Ezequiel"};
	String[] opSalmos= new String[]{"Proverbios","Cantares","Job","Eclesiastés","Ester"};
	String[] opClear = new String[0];
	
	Handler_sqlite helper;
	ContentValues valores;
	SQLiteDatabase dbOrigen;
	private ArrayList<String> list_cat;
	@Override
	protected void onCreate(Bundle savedInstanceState) {
		
		helper =  new Handler_sqlite(this);
		valores = new ContentValues();
		
		valores.put("categoria","historico");
		valores.put("categoria","carta");
		helper.setData("preguntas",valores);
		
		super.onCreate(savedInstanceState);
		setContentView(R.layout.activity_main);
		 btnIngresar 	= (Button)findViewById(R.id.btnIngresar);
		 
		 spCategoria 	= (Spinner)findViewById(R.id.spCategoria);
		 spEspecificar 	= (Spinner)findViewById(R.id.spEspecificar);
		 
		 spCategoria.setOnItemSelectedListener(this);
		 spEspecificar.setOnItemSelectedListener(this);
		 
		 list_cat = new ArrayList<String>();
		 list_cat = helper.getData2("SELECT * FROM preguntas");
		 
		 
		 aaCategoria = new ArrayAdapter<String>(this,android.R.layout.simple_spinner_item,list_cat);
		 //aaCategoria.setDropDownViewResource(android.R.layout.simple_spinner_dropdown_item); 
		 
		 aaProfetas = new ArrayAdapter<String>(this,android.R.layout.simple_spinner_item,opProfetas);
		 aaSalmos   = new ArrayAdapter<String>(this,android.R.layout.simple_spinner_item,opSalmos);
		 aaClear    = new ArrayAdapter<String>(this,android.R.layout.simple_spinner_item,opClear);
		 
		 spCategoria.setAdapter(aaCategoria);
		 spEspecificar.setAdapter(aaProfetas);
	
		 
		 btnIngresar.setOnClickListener(new View.OnClickListener() {
	      public void onClick(View v) {
	 
	    	  
	    	  	
	        	Toast.makeText(getApplicationContext(),"Hola ",Toast.LENGTH_SHORT).show();
	        	Intent nuevoInten = new Intent(MainActivity.this,Prueba_Buscar.class);
	        	startActivity(nuevoInten);
	        	}
			});
		 
		
		
		
	}

	@Override
	public void onItemSelected(AdapterView<?> parent, View view, int position,
			long id) {
		switch(parent.getId()) {
		case R.id.spCategoria:
			int seleccionado =spCategoria.getSelectedItemPosition();
			if(seleccionado==0) {spEspecificar.setAdapter(aaSalmos);}
			if(seleccionado==1) {spEspecificar.setAdapter(aaProfetas);}
			
			
		}
		
	}

	@Override
	public void onNothingSelected(AdapterView<?> parent) {
		// TODO Auto-generated method stub
		
	}
}
