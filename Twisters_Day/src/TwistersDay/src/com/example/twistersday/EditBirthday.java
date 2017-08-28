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
import android.widget.RadioButton;
import android.widget.TextView;
import android.widget.Toast;
import android.widget.ToggleButton;

public class EditBirthday extends Activity implements OnClickListener {
Button sqledit;
ToggleButton sqltglbtn;
EditText etname,etdob;
Calendar myCalendar;
long _id;
int val;
String msg="Android : ";
GetSet gs;
	@Override
	protected void onCreate(Bundle savedInstanceState) {
		// TODO Auto-generated method stub
		super.onCreate(savedInstanceState);
		setContentView(R.layout.edit_birth_day);
		myCalendar=Calendar.getInstance();
		sqledit=(Button) findViewById(R.id.btnupdate);
		sqltglbtn=(ToggleButton) findViewById(R.id.toggleBtnActive);
		
		etname=(EditText) findViewById(R.id.eteName);
		etdob=(EditText) findViewById(R.id.eTedob);
		
		etdob.setOnClickListener(this);
		sqledit.setOnClickListener(this);
		sqltglbtn.setOnClickListener(this);
		gs=new GetSet();
		etname.setText(gs.getName());
		etdob.setText(gs.getDob());
		sqltglbtn.setText(gs.getActive().equalsIgnoreCase("Y") ? "ON" : "OFF");

		
		//.equalsIgnoreCase("ON") ? "Y" : "N"
		//Log.d(msg, clickedView.getText().toString());
		
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

	@SuppressLint("NewApi") @Override
	public void onClick(View v) {
		// TODO Auto-generated method stub
		
		switch (v.getId()){
		case R.id.btnupdate:
			boolean DiditWork=true;
			boolean NotEmpty=true;
			try{
			String name=etname.getText().toString();
			String dob=etdob.getText().toString();
			String act=gs.getActive();
			//String act=sqltglbtn.getText().toString().equalsIgnoreCase("ON") ? "Y" : "N";
			Log.d(msg,name);
			Log.d(msg,dob);
			Log.d(msg,act);
			Log.d(msg, "inside empty check0" + dob);
			if(name.trim().isEmpty() && (dob.trim().isEmpty() || dob.trim().equalsIgnoreCase("dd/mm/yyyy"))){				
					Log.d(msg, "inside empty check");
					DiditWork=false;
					NotEmpty=false;				
			}				
			Log.d(msg, DiditWork + "::" + NotEmpty);
			if(NotEmpty){
				HotOrNot entry=new HotOrNot(EditBirthday.this);			
				entry.open();
				Log.d(msg, gs.getId() + "@" + name + "@" + dob + "@" + act);
				entry.updateEntry(gs.getId(), name, dob, act);
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
					tv.setText("Entry Updated");	
					etname.setText("");
					etdob.setText("dd/mm/yyyy");
				}else if(DiditWork!=true && NotEmpty==true){
					d.setTitle("Oop!");				
					tv.setText("Entry Not Updated");					
				}else{
					d.setTitle("Oop!");				
					tv.setText("Please Enter Name & D.O.B");
				}
				d.show();
			}
			break;
		case R.id.toggleBtnActive:
			TextView clickedView = (TextView) v;
	         //Toast.makeText(EditBirthday.this, "Item with id [" + clickedView.getText()+"]", 200).show();
	         //sqltglbtn.is
			Log.d(msg, clickedView.getText().toString());
			gs.setActive(clickedView.getText().toString().equalsIgnoreCase("ON") ? "Y" : "N");
		break;
		case R.id.eTedob:
			new DatePickerDialog( EditBirthday.this, date,
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
            etdob.setText(sdf.format(myCalendar.getTime()));
        
//Date d=new Date();
        }

}
	


