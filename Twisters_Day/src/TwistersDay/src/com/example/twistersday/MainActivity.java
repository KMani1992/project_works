package com.example.twistersday;

import java.util.List;
import java.util.Map;


import android.os.Bundle;
import android.app.Activity;
import android.content.Intent;
import android.util.Log;
import android.view.View;
import android.widget.AdapterView;

import android.widget.Button;
import android.widget.ListView;
import android.widget.SimpleAdapter;
import android.widget.TextView;
import android.widget.Toast;

public class MainActivity extends Activity{
	Button sqladd,sqlbday;
	ListView lstviw;
	SimpleAdapter simpAdapter;
    @Override
    protected void onCreate(Bundle savedInstanceState) {     	
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        sqladd=(Button) findViewById(R.id.btnAdd);
        sqlbday=(Button) findViewById(R.id.btnbday);
        lstviw=(ListView) findViewById(R.id.lstView);
        loadBirthday();        
        sqladd.setOnClickListener(new View.OnClickListener(){			
			public void onClick(View arg0) {
				// TODO Auto-generated method stub
				
				startActivity(new Intent("com.example.twistersday.ADDNEW"));
				
			}
		});
        sqlbday.setOnClickListener(new View.OnClickListener() {
			
			@Override
			public void onClick(View v) {
				// TODO Auto-generated method stub
				loadBirthday();
			}
		});
        
        lstviw.setOnItemLongClickListener(new AdapterView.OnItemLongClickListener() {

			@Override
			public boolean onItemLongClick(AdapterView<?> parentAdapter, View view,
					int position, long id) {				
				
				// We know the View is a TextView so we can cast it
		         TextView clickedView = (TextView) view;
		         //Toast.makeText(MainActivity.this, "Item with id ["+id+"] - Position ["+position+"] - Planet ["+clickedView.getText()+"]", Toast.LENGTH_SHORT).show();
				GetSet gs=new GetSet();
				String bdata=null;							
				bdata=clickedView.getText().toString();				
			
				String[] splval=new String[5];
				//public String [4]splval;
				splval=bdata.split("@");				
				String msg="and :";
				Log.d(msg, splval[0] + "#" + splval[1] + "#" + splval[2] + "#" + splval[3] + "#" );
				
				gs.setId(splval[0]);
				gs.setActive(splval[1]);
				gs.setName(splval[2]);
				gs.setDob(splval[3]);
				
				
				
				
				startActivity(new Intent("com.example.twistersday.EDITBIRTHDAY"));
				return false;
			}
		});

    }
    private void loadBirthday(){
    	HotOrNot hon =new HotOrNot(MainActivity.this);        
    	hon.open();    	
    	List<Map<String, String>> birthdayentry=hon.getBirthData();
        String[] key_id=hon.getKeyval();
        simpAdapter=new SimpleAdapter(this, birthdayentry, android.R.layout.simple_list_item_1,key_id , new int[] {android.R.id.text1});
        lstviw.setAdapter(simpAdapter);
        hon.close();
    }

	
}
