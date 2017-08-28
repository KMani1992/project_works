package com.example.twistersday;




import java.sql.Date;
import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.util.ArrayList;

import java.util.HashMap;
import java.util.List;
import java.util.Locale;
import java.util.Map;

import android.content.ContentValues;
import android.content.Context;
import android.database.Cursor;
import android.database.SQLException;
import android.database.sqlite.SQLiteDatabase;
import android.database.sqlite.SQLiteDatabase.CursorFactory;
import android.database.sqlite.SQLiteOpenHelper;
import android.util.Log;
import android.widget.SimpleAdapter;

public class HotOrNot {
	
	public static final String KEY_ROWID="_id";
	public static final String KEY_NAME="persons_name";
	public static final String KEY_DOB="persons_dob";
	public static final String KEY_Active="active";
	public static final String KEY_DAYS="(strftime('%j',(strftime('%Y','now') || '-' || strftime('%m'," + KEY_DOB  + ") || '-' || strftime('%d'," + KEY_DOB  + ")))-strftime('%j','now'))-1";
	//public static final String KEY_DAYHELPER="strftime('%Y'," + KEY_DOB + "),strftime('%m'," + KEY_DOB + "),strftime('%d'," + KEY_DOB + ")";
	
	private static final String DATABASENAME="TwistersDay";
	private static final String DATABASE_TABLE="Twisters";
	private static final int DATABASE_VERSION=1;
	
	private DbHelper ourHelper;
	private final Context ourContext;
	private SQLiteDatabase ourDatabase;
	
	static String msg="Android : ";
	private static class DbHelper extends SQLiteOpenHelper{

		public DbHelper(Context context) {
			super(context, DATABASENAME, null, DATABASE_VERSION);
			// TODO Auto-generated constructor stub
			//System.out.println("dbhelper");
		}

		@Override
		public void onCreate(SQLiteDatabase db) {
			// TODO Auto-generated method stub
			Log.d(msg,"create db");
			db.execSQL("CREATE TABLE " + DATABASE_TABLE +  " (" +
				KEY_ROWID + " INTEGER PRIMARY KEY AUTOINCREMENT, " +
				KEY_NAME + " TEXT NOT NULL, " +
				KEY_DOB + " DATE NOT NULL, " +
				KEY_Active + " TEXT NOT NULL);" 
					);
			
		}

		@Override
		public void onUpgrade(SQLiteDatabase db, int oldVersion, int newVersion) {
			// TODO Auto-generated method stub
			Log.d(msg,"upgrade");			
			db.execSQL("DROP TABLE IF EXISTS " + DATABASE_TABLE );
			onCreate(db);
		}
		
	}
	public HotOrNot(Context c){
		ourContext=c;
		Log.d(msg,"hotornot");
	}
	public HotOrNot open() throws SQLException{		
		ourHelper=new DbHelper(ourContext);
		ourDatabase=ourHelper.getWritableDatabase();		
		return this;
	}
	public void createEntry(String name,String dob){
		Log.d(msg,name);
		Log.d(msg,dob);		
		ContentValues cv =new ContentValues();
		cv.put(KEY_NAME, name);
		Log.d(msg,"calling df input");
		cv.put (KEY_DOB, formateDbIdate(dob));
		Log.d(msg, formateDbIdate(dob));
		ourDatabase.insert(DATABASE_TABLE, null, cv);
	}
	public void close() {
		// TODO Auto-generated method stub
		ourHelper.close();
	}
	public String getData(){
		String[] columns=new String[] {KEY_ROWID,KEY_NAME,KEY_DOB,KEY_DAYS};
		Cursor c=ourDatabase.query(DATABASE_TABLE, columns, null, null, null, null, KEY_NAME);
		String result="";
		int iRow=c.getColumnIndex(KEY_ROWID);
		int iName=c.getColumnIndex(KEY_NAME);
		int iDow=c.getColumnIndex(KEY_DOB);
		int iDays=c.getColumnIndex(KEY_DAYS);
		
		for(c.moveToFirst();!c.isAfterLast();c.moveToNext()){
			result=result + c.getString(iRow) + " " + c.getString(iName) + " " + c.getString(iDow) + "\n";			
		}
		return result;
	}
	public void updateEntry(String iRow,String iName,String iDow,String iAct){
		ContentValues cv=new ContentValues();		
		cv.put(KEY_NAME,iName);
		Log.d(msg, iName);		
		Log.d(msg, iDow + "test date bef");
		cv.put(KEY_DOB, formateDbIdate(iDow));
		Log.d(msg, formateDbIdate(iDow));
		Log.d(msg, iDow + "test date af");
		cv.put(KEY_Active, iAct);		
		Log.d(msg, iAct);
		long ir=Long.parseLong(iRow);
		Log.d(msg, iRow);
		ourDatabase.update(DATABASE_TABLE, cv, KEY_ROWID + "=" + ir,null);		
	}
	public void deleteEntry(long irow){
		ourDatabase.delete(DATABASE_TABLE, KEY_ROWID + "=" + irow, null);
	}
	public String[] getKeyval() {
		// TODO Auto-generated method stub
		
		String[] key_id=new String[1];
		key_id[0]="Contact";
		
		return key_id;
	}
	public List<Map<String, String>> getBirthData() {
		// TODO Auto-generated method stub
		Log.d(msg,"inside getbirthdata1c");
		
		/*ourDatabase.execSQL("DROP TABLE IF EXISTS " + DATABASE_TABLE );
		ourDatabase.execSQL("CREATE TABLE " + DATABASE_TABLE +  " (" +
				KEY_ROWID + " INTEGER PRIMARY KEY AUTOINCREMENT, " +
				KEY_NAME + " TEXT NOT NULL, " +
				KEY_DOB + " TEXT NOT NULL, " +
				KEY_Active + " TEXT NOT NULL DEFAULT 'Y');" 
					);*/
		
		List<Map<String, String>> birthdayentry =new ArrayList<Map<String,String>>();
		String[] columns=new String[] {KEY_ROWID,KEY_NAME,KEY_DOB,KEY_Active,KEY_DAYS};
		///String[] columns=new String[] {KEY_ROWID,KEY_NAME,KEY_DOB,KEY_Active};
		
		Log.d(msg,"inside getbirthdata2");
		//ourDatabase.query(table, columns, selection, selectionArgs, groupBy, having, orderBy)
		//String wherCon="(strftime('%d'," + KEY_DOB + ")>=strftime('%d','now')) AND (strftime('%m'," + KEY_DOB + ")>=strftime('%m','now')) AND (strftime('%Y'," + KEY_DOB + ")<=strftime('%Y','now'))";
		String wherCon="strftime('%j'," + KEY_DOB + ") <=366";
		//String orderByCl="strftime('%Y'," + KEY_DOB + "),strftime('%m'," + KEY_DOB + "),strftime('%d'," + KEY_DOB + ")";
		String orderByCl= KEY_Active  + ",strftime('%m'," + KEY_DOB  + ") desc,strftime('%d'," + KEY_DOB  + ")," + KEY_NAME ;
		Log.d(msg, wherCon);
		Log.d(msg, orderByCl);
		//Cursor c=ourDatabase.query(DATABASE_TABLE, columns, wherCon , null, null, null, orderByCl);
		Cursor c=ourDatabase.query(DATABASE_TABLE, columns, null , null, null, null, orderByCl);
		Log.d(msg,"inside getbirthdata3");
		String result="";
		
		int iRow=c.getColumnIndex(KEY_ROWID);
		int iName=c.getColumnIndex(KEY_NAME);
		int iDow=c.getColumnIndex(KEY_DOB);
		int iactive=c.getColumnIndex(KEY_Active);
		int iDays=c.getColumnIndex(KEY_DAYS);
		
		Log.d(msg,"inside getbirthdata");
		String nofdays="";
		for(c.moveToFirst();!c.isAfterLast();c.moveToNext()){
			Log.d(msg,"inside getbirthdataloop");
			result="";
			nofdays="";			
			nofdays=c.getString(iDays).toString().equalsIgnoreCase("0") ? "Today" : c.getString(iDays) + " DaysRemaining";
			if(c.getString(iactive).toString().equalsIgnoreCase("Y")){
				//if(Long.parseLong(c.getString(iDays))>=0){
					result= c.getString(iRow) + "@" + c.getString(iactive) + "@" + c.getString(iName) + "@" + formateDbOdate(c.getString(iDow)) + "\n@" + nofdays;
				//}else{
					//result= c.getString(iRow) + "@" + c.getString(iactive) + "@" + c.getString(iName) + "@" + formateDbOdate(c.getString(iDow));	
				//}
					
			}else{
				result= c.getString(iRow) + "@" + c.getString(iactive) + "@" + c.getString(iName) + "@" + formateDbOdate(c.getString(iDow));
			}
			Log.d(msg,result.toString());
			birthdayentry.add(createBirthday("Contact",result.toString()));
		}
		
		return birthdayentry;
	}
	private HashMap<String, String> createBirthday(String key, String name) {
	    HashMap<String, String> planet = new HashMap<String, String>();
	    planet.put(key, name);
	    return planet;
	}
	
	private String formateDbIdate(String inputdt){
		/* String myFormat = "yyyy-MM-dd"; //In which you need put here
		 
		 //Date ind=java.sql.Date(inputdt);	
		// Date ind=
		 Log.d(msg, inputdt + "tstw");
		java.sql.Date sdtf = new java.sql.Date(java.util.Date.parse(inputdt));
	     SimpleDateFormat sdf = new SimpleDateFormat(myFormat, Locale.US);
	     
	     Log.d(msg, sdf.format(sdtf));
	     Log.d(msg, sdf.format(sdtf));*/
		String[] splval=new String[3];		
		splval=inputdt.split("/");	
		Log.d(msg,  splval[2] +  "-" + splval[1] +  "-" + splval[0]);
		return splval[2] +  "-" + splval[1] +  "-" + splval[0];
	}
	private String formateDbOdate(String inputdt){
		/* String myFormat = "dd/MM/yyyy"; //In which you need put here
		 //java.sql.Date sdtf = new java.sql.Date(java.util.Date.parse(inputdt));
	     SimpleDateFormat sdf = new SimpleDateFormat(myFormat, Locale.US);
	     Date ind=Date.valueOf(inputdt);
	     Log.d(msg, sdf.format(ind));*/
		String[] splval=new String[3];		
		splval=inputdt.split("-");	
		Log.d(msg, "out" + splval[2] +  "/" + splval[1] +  "/" + splval[0]);
		return splval[2] +  "/" + splval[1] +  "/" + splval[0];
	}
	
	
}
