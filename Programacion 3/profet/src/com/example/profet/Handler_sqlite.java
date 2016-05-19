package com.example.profet;

import java.util.ArrayList;
import java.util.List;

import android.content.ContentValues;

import android.content.Context;
import android.database.Cursor;
import android.database.SQLException;
import android.database.sqlite.SQLiteDatabase;
import android.database.sqlite.SQLiteOpenHelper;
import android.util.Log;

import static android.provider.BaseColumns._ID;


public class Handler_sqlite extends SQLiteOpenHelper{
	SQLiteDatabase dbOrigen;
	public Handler_sqlite(Context ctx) {
		
			super(ctx,"DB_Name",null,1);
			Log.d("SQL","DB_Name CREADA");
			Log.e("SQL","DB_Name CREADA");
	}

	@Override
	public void onCreate(SQLiteDatabase db) {
			Log.d("SQL","TABLA  preguntas A UN CREANDOCE");
			
			String query="CREATE TABLE preguntas ("+
				" libro TEXT," +
				" textamento TEXT," +
				"categoria TEXT," +
				"capitulo INTEGER," +
				" verso TEXT," +
				"pregunta TEXT," +
				"respuesta TEXT)";
		
			db.execSQL(query);
			Log.d("SQL","TABLA  preguntas CREADA");
			
			
		/*
		db.execSQL("CREATE TABLE categorias (id_categoria INTEGER PRIMARY KEY AUTOINCREMENT, nombre TEXT(50))");
		db.execSQL("CREATE TABLE libros (id_libro INTEGER PRIMARY KEY AUTOINCREMENT, nombre TEXT(50)");
		db.execSQL("CREATE TABLE libros_categorias (id_libro_categoria INTEGER PRIMARY KEY AUTOINCREMENT,id_categoria INTEGER,id_libro INTEGER," +
				"FOREIGN KEY(id_categoria) REFERENCES categorias(id_categoria)," +
				"FOREIGN KEY(id_libro) REFERENCES libros(id_libro)"
				);
		
		db.execSQL("CREATE TABLE preguntas (id_pregunta INTEGER PRIMARY KEY AUTOINCREMENT, pregunta TEXT(150),respuesta TEXT(250),id_libro INTEGER ," +
				"FOREIGN KEY(id_libro) REFERENCES libros(id_libro))");
		
		*/
		Log.d("SQL","TABLA preguntas CREADA");
		Log.e("SQL","TABLA preguntas CREADA");
		Log.v("SQL","TABLA preguntas CREADA");
		Log.w("SQL","TABLA preguntas CREADA");
	}

	@Override
	public void onUpgrade(SQLiteDatabase db, int ant_Version, int new_Version) {
		db.execSQL("DROP TABLE IF EXISTS preguntas");
		onCreate(db);
		
	}
	
	public boolean setData(String tabla,ContentValues contentValues)
	{
		try {
			SQLiteDatabase db = getWritableDatabase();
			db.insert(tabla, null, contentValues);
	      return true;
		} catch (Exception e) {
	 		e.getMessage();
	 		Log.e("SQL","ERROR DE INSERCION EN TABLA"+tabla);
	 		Log.d("SQL","ERROR DE INSERCION EN TABLA"+tabla);
		    return false;
		}
	}
	
	
	
	public Cursor getData(String sql){
		try {
			Cursor res = this.getReadableDatabase().rawQuery(sql, null );
		      if(res != null)
			 	{
			 		return res;
			 	}
			 	else
			 	{
			 		return null;
			 	}
		 
		 	} catch (Exception e) {
		 		e.getMessage();
			    return null;
			}
	}
	
	public ArrayList<String> getData2(String sql){
		try {
			SQLiteDatabase db = getReadableDatabase();
			ArrayList<String> lista = new ArrayList<String>();
			int cate = 0;
			Cursor res = db.rawQuery(sql, null );
		      if(res != null)
			 	{
		    	  while(res.moveToNext()) {
		    		  cate = res.getColumnIndex("categoria");
		    		  lista.add(res.getPosition(),res.getString(cate).toString());
		    	  	}
			 		return lista;
			 	}
			 	else
			 	{
			 		return null;
			 	}
		      
		 
		 	} catch (Exception e) {
		 		e.getMessage();
			    return null;
			}
	}
	public ArrayList<String> consultar() { 
        // TODO Auto-generated method stub 
        String[] allColumns = new String[] {"categoria"}; 
        Cursor c = dbOrigen.query("preguntas", allColumns, null, 
                null, null, null, null); 
        if (c != null) { 
            c.moveToFirst(); 
        } 
        return null; 
    } 
	
	public boolean InsertRegAvances(String sql) {
		try {
			this.getWritableDatabase().execSQL(sql);
			return true;
		}catch(Exception e) {
			e.getMessage();
			return false;
		}
	}
	

}
