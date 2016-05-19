package com.example.profet;

import android.database.sqlite.SQLiteDatabase;
import android.app.Activity;
import android.database.Cursor;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.TextView;
import android.widget.Toast;

public class Prueba_Buscar extends Activity {
	
	Button   b_buscar;
	TextView retorno;
	EditText texto_b;
	
	@Override
	protected void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		setContentView(R.layout.buscar);
		
		texto_b  = (EditText) findViewById(R.id.eTbuscar);
		b_buscar = (Button)   findViewById(R.id.btn_buscar);
		retorno  = (TextView) findViewById(R.id.tVtexto);
		
		b_buscar.setOnClickListener(new View.OnClickListener() {
			
			@Override
			public void onClick(View v) {
				 buscar();
			}
		});
	}
	
	 public void buscar()
	    {
		 Handler_sqlite dbh=new Handler_sqlite(this);
	      	SQLiteDatabase db= dbh.getWritableDatabase();
	      	
	      	String[] campos = new String[] {"nombre"};
	      	String[] args = new String[] {texto_b.getText().toString()};
	      	String pasar_texto = texto_b.getText().toString();
	      	 
	      	Cursor cursor = db.query("usuarios", campos, "nombre="+pasar_texto, args, null, null, null);
	      
	      	
	      	if (cursor.moveToFirst()) {
	      	   int cnombre = cursor.getColumnIndex("nombre");
	      	   retorno.setText(cursor.getString(cnombre));
	      	}else{
	      	Toast.makeText(getApplicationContext(), 
	 	      		  "El contacto especificado no existe.!", Toast.LENGTH_LONG).show();
	      	db.close();
	      	}
	    }
}
