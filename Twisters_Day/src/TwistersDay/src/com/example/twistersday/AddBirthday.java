package com.example.twistersday;


import java.text.SimpleDateFormat;
import java.util.Calendar;
import java.util.Locale;

import android.annotation.SuppressLint;
import android.app.Activity;
import android.app.DatePickerDialog;
import android.app.Dialog;
import android.os.Bundle;
import android.util.Log;
import android.view.View;
import android.view.View.OnClickListener;
import android.widget.Button;
import android.widget.DatePicker;
import android.widget.EditText;
import android.widget.TextView;

@SuppressLint("NewApi") public class AddBirthday extends Activity implements OnClickListener {
	Button sqladd,sqlhome;
	EditText sqlname,sqldob;
	static String msg="Android : ";
	Calendar myCalendar;
	int val;

	@Override
	protected void onCreate(Bundle savedInstanceState) {
		// TODO Auto-generated method stub
		super.onCreate(savedInstanceState);
		setContentView(R.layout.add_birthday);
		myCalendar=Calendar.getInstance();
		sqlname=(EditText) findViewById(R.id.etName);
		sqldob=(EditText)findViewById(R.id.eTdob);
		sqladd=(Button) findViewById(R.id.btnsave);
		sqlhome=(Button) findViewById(R.id.btnhome);
		sqladd.setOnClickListener(this);
		sqldob.setOnClickListener(this);
		//sqlhome.setOnClickListener(this);
	}
	
	
	final DatePickerDialog.OnDateSetListener date = new DatePickerDialog.OnDateSetListener() {


        @Override
        public void onDateSet(DatePicker view, int year, int monthOfYear,
                int dayOfMonth) {
            // TODO Auto-generated method stub
             myCalendar.set(Calendar.YEAR, year);
                myCalendar.set(Calendar.MONTH, monthOfYear);
                myCalendar.set(Calendar.DAY_OF_MONTH, dayOfMonth);
                updateLabel(val);

        }

    };
	
	@Override
	public void onClick(View v) {
		// TODO Auto-generated method stub
		
		switch (v.getId()){
		case R.id.btnsave:
			boolean DiditWork=true;
			boolean NotEmpty=true;
			try{
			String name=sqlname.getText().toString();
			String dob=sqldob.getText().toString();	
			Log.d(msg,name);
			Log.d(msg,dob);
			Log.d(msg, "inside empty check0" + dob);
			if(name.trim().isEmpty() && (dob.trim().isEmpty() || dob.trim().equalsIgnoreCase("dd/mm/yyyy"))){				
					Log.d(msg, "inside empty check");
					DiditWork=false;
					NotEmpty=false;				
			}				
			Log.d(msg, DiditWork + "::" + NotEmpty);
			if(NotEmpty){
				HotOrNot entry=new HotOrNot(AddBirthday.this);	
				Log.d(msg, DiditWork + "::1" + NotEmpty);
				entry.open();
				Log.d(msg, DiditWork + "::12" + NotEmpty);
				entry.createEntry(name, dob);
				Log.d(msg, DiditWork + "::13" + NotEmpty);
				entry.close();
			}
			}catch(Exception e){				
				DiditWork=false;
				e.printStackTrace();
			}finally{
				Dialog d=new Dialog(this);
				TextView tv=new TextView(this);
				d.setContentView(tv);
				if(DiditWork==true && NotEmpty==true){				
					d.setTitle("Success!");				
					tv.setText("Entry Saved");	
					sqlname.setText("");
					sqldob.setText("dd/mm/yyyy");
				}else if(DiditWork!=true && NotEmpty==true){
					d.setTitle("Oop!");				
					tv.setText("Entry Not Saved");					
				}else{
					d.setTitle("Oop!");				
					tv.setText("Please Enter Name & D.O.B");
				}
				d.show();
			}
		break;
		case R.id.eTdob:
			
			/*Dialog mDialog=new DatePickerDialog(AddBirthday.this,
					mDatesetlistener,
					Calendar.get(Calendar.YEAR),
					Calendar.get(Calendar.MONTH), 
					Calendar.get(Calendar.DAY_OF_MONTH));
			mDialog.show();*/
			new DatePickerDialog(AddBirthday.this, date,
					myCalendar.get(Calendar.YEAR),
					myCalendar.get(Calendar.MONTH),
					myCalendar.get(Calendar.DAY_OF_MONTH)).show();
			val=1;
		break;		
		}
		
	}
	
	private void updateLabel(int val) {

        String myFormat = "dd/MM/yyyy"; //In which you need put here
        SimpleDateFormat sdf = new SimpleDateFormat(myFormat, Locale.US);
        if(val==1)
            sqldob.setText(sdf.format(myCalendar.getTime()));
        
//Date d=new Date();
        }

}
