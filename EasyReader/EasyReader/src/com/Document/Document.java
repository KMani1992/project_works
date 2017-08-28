package com.Document;

import java.io.*;
import java.awt.*;
import java.awt.event.*;
import javax.swing.*;
import javax.swing.border.Border;
import javax.swing.filechooser.FileNameExtensionFilter;

import java.awt.event.ActionListener;
import java.awt.event.MouseEvent;
import java.awt.event.MouseAdapter;

import java.sql.*;
import java.io.File;



public class Document extends JFrame 
{
/**
	 * 
	 */
	
	
	private static final long serialVersionUID = 1L;
//main class start start 
JMenuItem menuitem;
private JPopupMenu popupmenu;
JScrollPane js;
JTextArea jta;
File file;
Font ft;
String fn=null;

String selected;
String selectedget=null;
String select=null;
int xpos;
int ypos;
//private JPopupMenu popupmenu;
JEditorPane jep;
JProgressBar jp;
JComboBox jcb;
JLabel stat;
Long startTime,endTime;
int i=0,j=0,k;
int cou=1;
Connection con= null;
Statement st=null;
ResultSet rs=null;
String ser=null;
JToolBar tb;
boolean check=false;
public Border border;

public Document()
{
//main method start 
BorderLayout bl=new BorderLayout();
setLayout(bl);
JMenuBar mbr=new JMenuBar();
JMenu space=new JMenu("");
JMenu menu=new JMenu("File");
JMenu menu1=new JMenu("Settings");
JMenu menu2=new JMenu("Help");

JMenuItem mi1=new JMenuItem("Open...",new ImageIcon("open-file.png"));
JMenuItem mi2=new JMenuItem("Notes...",new ImageIcon("notes_icon1.png"));
JMenuItem mi4=new JMenuItem("Exit");
JMenuItem mi5=new JMenuItem("Options...",new ImageIcon("settings12.png"));
JMenuItem mi6=new JMenuItem("View Help");
JMenuItem mi7=new JMenuItem("About EReader");
menu.add(mi1);
menu.add(mi2);
menu.addSeparator();
menu.add(mi4);
menu1.add(mi5);
menu2.add(mi6);
menu2.addSeparator();
menu2.add(mi7);

jcb = new JComboBox();
jcb.addItem("Mode");
jcb.addItem("Eng - Eng");
//jcb.addItem("Eng - Tamil");


mbr.add(space);
mbr.add(menu);
mbr.add(menu1);
mbr.add(menu2);

setJMenuBar(mbr);
jta=new JTextArea(150,150);
jta.setLineWrap(true);
ft=new Font("Dialog input",Font.PLAIN,16);
jta.setFont(ft);
jta.setEditable(false);
js=new JScrollPane(jta);
add(js,BorderLayout.CENTER);






MyMenuHandler handler = new MyMenuHandler(this);
mi1.addActionListener(handler);
mi2.addActionListener(handler);
mi4.addActionListener(handler);
mi5.addActionListener(handler);
mi6.addActionListener(handler);
mi7.addActionListener(handler);
MyWindowAdapter adapter = new MyWindowAdapter(this);
addWindowListener(adapter);

popupmenu=new JPopupMenu();
ItemHandler itemHandler = new ItemHandler(menuitem);
menuitem=new JMenuItem("Online Dict");
menuitem.addActionListener(itemHandler);
popupmenu.add(menuitem);
menuitem=new JMenuItem("Offline Dict");
menuitem.addActionListener(itemHandler);
popupmenu.add(menuitem);
MouseListener popup=new PopupListener(popupmenu);
jta.addMouseListener(popup);
//toolbar

tb = new JToolBar("Easy Reader");
  
add(tb, BorderLayout.PAGE_START);
 
JButton b1 = new JButton("Open",new ImageIcon("C:\\Program Files\\Java\\jdk1.6.0_21\\bin\\jp\\ap\\pra\\open-file.png"));
   
b1.setPreferredSize( new Dimension(122,32));
  
tb.add(b1);
    
b1.setToolTipText("Open File");
JButton b2 = new JButton("Notes",new ImageIcon("C:\\Program Files\\Java\\jdk1.6.0_21\\bin\\jp\\ap\\pra\\notes_icon1.png"));
   
b2.setPreferredSize( new Dimension(122,32));
 
tb.add(b2);
    
b2.setToolTipText("Notes");
JButton b3 = new JButton("Options",new ImageIcon("C:\\Program Files\\Java\\jdk1.6.0_21\\bin\\jp\\ap\\pra\\settings12.png"));
   
b3.setPreferredSize( new Dimension(122,32));
 
tb.add(b3);

jcb.setPreferredSize(new Dimension(122,32));
tb.add(jcb);





b3.setToolTipText("Options");

b1.addActionListener(handler);
b2.addActionListener(handler);
b3.addActionListener(handler);

}
//main method end

class MyWindowAdapter extends WindowAdapter 
{
Document menuFrame;
public MyWindowAdapter(Document menuFrame) 
{
this.menuFrame = menuFrame;
}
    }
//window adapter end
//menu handler start
class MyMenuHandler implements ActionListener {
Document menuFrame;
public MyMenuHandler(Document menuFrame) {
this.menuFrame = menuFrame;
}

//menu method start
public void actionPerformed(ActionEvent ae)
 {
String arg = ae.getActionCommand();
if(arg.equals("Open...")||arg.equals("Open"))
{

JFileChooser jfs = new JFileChooser();
FileNameExtensionFilter fef=new FileNameExtensionFilter("textfiles","txt");
jfs.setFileFilter(fef);

int returnvalue=jfs.showOpenDialog(js);

if(returnvalue==JFileChooser.APPROVE_OPTION)

file=jfs.getSelectedFile();
fn=jfs.getName(file);
//System.out.println(fn);
DocumentReader.filename(fn);
try
{
	
BufferedReader in=new BufferedReader(new FileReader(file));
jta.setText("");
jta.setBorder( border);
jta.setMargin(getInsets());
jta.setAlignmentX(CENTER_ALIGNMENT);
jta.setAlignmentY(TOP_ALIGNMENT);
String line=in.readLine();
while(line!=null)
{

jta.append(line+"\n");


line=in.readLine();

/*
int kk=line.length();
StringBuffer bll=new StringBuffer(line);

String srr=bll.toString();
String []seperate=srr.split(";");
if(cou>1)
{
cou=1;
}
for(String pr:seperate)
{
//jta.append(cou+")\n"+pr+"\n");

++cou;

}

*/


}
}
catch(Exception e)
{
//JOptionPane.showMessageDialog( null, "No File Has Choosen" );
}

}
else if(arg.equals("Note...")||arg.equals("Notes"))
{
Writer jwr=new Writer();
jwr.setVisible(true);
//jwr.setSize(230,320);
jwr.setBounds(450, 35, 270, 320);
jwr.setTitle("Notes - EasyReader");
}

else if(arg.equals("Options...")||arg.equals("Options"))
{

//JOptionPane.showMessageDialog(null,"Options");

TextSettings ts=new TextSettings();
ts.setVisible(true);
//ts.setSize(400,130);
ts.setBounds(450, 35, 400, 130);
ts.setTitle("Settings - EasyReader");
}

else if(arg.equals("View Help"))
{

Help hel=new Help();
hel.setVisible(true);
//hel.setSize(350,350);
hel.setBounds(450, 35, 400, 400);
hel.setTitle("Help ands Support - EasyReader");
//JOptionPane.showMessageDialog(null,"Options");

}

else if(arg.equals("About EReader"))
{
About abou=new About();
abou.setVisible(true);
//abou.setSize(300,300);
abou.setBounds(450, 35, 300, 300);
abou.setTitle("About - EasyReader");


//JOptionPane.showMessageDialog(null,"EReader");

}


else if(arg.equals("Exit"))
{
System.exit(1);
}
}
//menu method end

//text settings class start
class TextSettings extends JFrame
{
/**
	 * 
	 */
	private static final long serialVersionUID = 1L;
String font[] = {"PLAIN","BOLD","ITALIC"};
String size[] = {"12","14","16","18","20","22","24","26"};
Color c,d,e,f,g,h,i,j;
JComboBox sty,fo,si;
JButton jc1,jc2,jc3,jc4,jc5,jc6,jc7,jc8;
TextSettings()
{
JTabbedPane jtp = new JTabbedPane();
jtp.addTab("Font", new CitiesPanel());
jtp.addTab("Background Color", new ColorsPanel());
jtp.addTab("Foreground Color", new FlavorsPanel());
add(jtp);
}
class CitiesPanel extends JPanel {
/**
	 * 
	 */
	private static final long serialVersionUID = 1L;
public CitiesPanel() {
ItemHandle handle=new ItemHandle(fo);
JLabel fontstyle=new JLabel("Font Style");
fo=new JComboBox(font);
JLabel fontsize=new JLabel("Font Size");
si=new JComboBox(size);
add(fontstyle);
add(fo);
add(fontsize);
add(si);
fo.addActionListener(handle);
si.addActionListener(handle);
}
public Insets getInsets() {
return new Insets(10, 10, 10, 10);
}
}
class ColorsPanel extends JPanel {
/**
	 * 
	 */
	private static final long serialVersionUID = 1L;

public ColorsPanel() {
 c=new Color(0,0,0);
 d=new Color(255,255,255);
 e=new Color(253,206,165);
 f=new Color(15,104,59);
JLabel label2= new JLabel( "Background", SwingConstants.LEFT );
add(label2);
 jc1=new JButton("back1");
 jc2=new JButton("back2");
 jc3=new JButton("back3");
 jc4=new JButton("back4");
 add(jc1);
add(jc2);
add(jc3);
add(jc4);
jc1.setBackground(c);
jc2.setBackground(d);
jc3.setBackground(e);
jc4.setBackground(f);
ItemHandler handler=new ItemHandler(jc5);
jc1.addActionListener(handler);
jc2.addActionListener(handler);
jc3.addActionListener(handler);
jc4.addActionListener(handler);
}
}
class FlavorsPanel extends JPanel {
/**
	 * 
	 */
	private static final long serialVersionUID = 1L;

public FlavorsPanel() {
JLabel label3 = new JLabel( "Foreground", SwingConstants.LEFT );
add(label3);
 g=new Color(0,0,0);
 h=new Color(255,255,255);
 i=new Color(250,3,26);
 j=new Color(15,104,59);
 jc5=new JButton("Col1");
 jc6=new JButton("Col2");
 jc7=new JButton("Col3");
 jc8=new JButton("Col4");
 add(jc5);
add(jc6);
add(jc7);
add(jc8);
jc5.setForeground(g);
jc6.setForeground(h);
jc7.setForeground(i);
jc8.setForeground(j);
ItemHandler handler=new ItemHandler(jc5);
jc5.addActionListener(handler);
jc6.addActionListener(handler);
jc7.addActionListener(handler);
jc8.addActionListener(handler);
}}
class ItemHandler implements ActionListener
{
JButton jc5;
 ItemHandler(JButton jc5)
{
this.jc5=jc5;
}
public void actionPerformed(ActionEvent ae)
{
if(ae.getActionCommand()=="back1"){jta.setBackground(c);}
if(ae.getActionCommand()=="back2"){jta.setBackground(d);}
if(ae.getActionCommand()=="back3"){jta.setBackground(e);}
if(ae.getActionCommand()=="back4"){jta.setBackground(f);}
if(ae.getActionCommand()=="Col1"){jta.setForeground(g);}
if(ae.getActionCommand()=="Col2"){jta.setForeground(h);}
if(ae.getActionCommand()=="Col3"){jta.setForeground(i);}
if(ae.getActionCommand()=="Col4"){jta.setForeground(j);}
}
}
class ItemHandle implements ActionListener
{
JComboBox fo;
 ItemHandle(JComboBox fo)
{
this.fo=fo;
}
public void actionPerformed(ActionEvent e)
{
JComboBox cb=(JComboBox)e.getSource();
if((String)cb.getSelectedItem()=="PLAIN"){jta.setFont(ft.deriveFont(Font.PLAIN));}
if((String)cb.getSelectedItem()=="BOLD"){jta.setFont(ft.deriveFont(Font.BOLD));}
if((String)cb.getSelectedItem()=="ITALIC"){jta.setFont(ft.deriveFont(Font.ITALIC));}
if((String)cb.getSelectedItem()=="12"){jta.setFont(ft.deriveFont(12.0f));}
if((String)cb.getSelectedItem()=="14"){jta.setFont(ft.deriveFont(14.0f));}
if((String)cb.getSelectedItem()=="16"){jta.setFont(ft.deriveFont(16.0f));}
if((String)cb.getSelectedItem()=="18"){jta.setFont(ft.deriveFont(18.0f));}
if((String)cb.getSelectedItem()=="20"){jta.setFont(ft.deriveFont(20.0f));}
if((String)cb.getSelectedItem()=="22"){jta.setFont(ft.deriveFont(22.0f));}
if((String)cb.getSelectedItem()=="24"){jta.setFont(ft.deriveFont(24.0f));}
if((String)cb.getSelectedItem()=="26"){jta.setFont(ft.deriveFont(26.0f));}
}
}

}
//text setting end



}


//pop up menu adapter start

class PopupListener extends MouseAdapter
{ 
JPopupMenu popupmenu;
public PopupListener(JPopupMenu popupmenu)
{
this.popupmenu=popupmenu;
}
public void mousePressed(MouseEvent event)
{
CheckTrigerEvent(event);
}
public void mouseReleased(MouseEvent event)
{
CheckTrigerEvent(event);
}
public void mouseClicked(MouseEvent me)
{
if(me.getClickCount()==2)
{
	 xpos=me.getX();
	 ypos=me.getY();
	 if(xpos>1000)
		 xpos=900;
selected=jta.getSelectedText();

if(selected!=null)
{
Dict jdt=new Dict(selected);

jdt.setVisible(true);
//jdt.setSize(300,350250, 5,);
jdt.setBounds(xpos+70, ypos+10, 300, 350);
jdt.setTitle("Dictinnary - EasyReader");
jdt.display();
}
}
}
private void CheckTrigerEvent(MouseEvent event)
{
	
if(event.isPopupTrigger())
{
popupmenu.show(event.getComponent(),event.getX(),event.getY());
xpos=event.getX();
ypos=event.getY();
if(xpos>1000)
	 xpos=900;
}
}
}
//pop up menu adapter end

//pop up menu item handler start
class ItemHandler implements ActionListener
{
JMenuItem menuitem;
public ItemHandler(JMenuItem menuitem)
{
this.menuitem=menuitem;
} 
public void actionPerformed(ActionEvent ae)
{

if(ae.getActionCommand()=="Online Dict")
{
selected=jta.getSelectedText();
if(selected!=null)
{
    //SimpleSwingBrowser ss=new SimpleSwingBrowser();
    //ss.SimpleSwingBrowser(selected);
    SwingUtilities.invokeLater(new SimpleSwingBrowser(selected,xpos,ypos));
    
/*row bow=new Brow(selected);

bow.setVisible(true);
//bow.setSize(400,500);
bow.setBounds(xpos+70, ypos+10, 400, 500);
bow.setTitle("Online Dictinnary - EasyReader");
bow.display();*/
}
}
if(ae.getActionCommand()=="Offline Dict")
{
selected=jta.getSelectedText();
if(selected!=null)
{
Dict jdt=new Dict(selected);
jdt.setVisible(true);
jdt.setBounds(xpos+70, ypos+10, 300, 350);
jdt.setTitle("Dictinnary - EasyReader");
jdt.display();
}
}

if(ae.getActionCommand()=="Offline Dict"&&(String)jcb.getSelectedItem()=="Eng - Tamil")
{
selected=jta.getSelectedText();
if(selected!=null)
{
Dicta jdta=new Dicta(selected);
jdta.setVisible(true);
jdta.setBounds(xpos+70, ypos+10, 300, 350);
//jdta.setSize(300,350);
jdta.setTitle("Dictinnary - EasyReader");
jdta.display();
}
}


}
}
//pop up menu item handler start

//english dict connection class start 

public class Dict extends JFrame
{
/**
	 * 
	 */
	private static final long serialVersionUID = 1L;
String selectedget1;
TextField tf;
JTextArea sta;
Font footer;
JScrollPane jsd;
String sersel=null;
public Dict(String selectedget1)
{
this.selectedget1=selectedget1;
}
public void display()
{
ser=(String)selectedget1.toLowerCase();
sersel=ser;
BorderLayout bdl=new BorderLayout();
setLayout(bdl);
tf=new TextField(selectedget1);
Font header=new Font("Dialog",Font.BOLD,14);
tf.setFont(header);
add(tf,BorderLayout.NORTH);
sta=new JTextArea(10,30);

sta.setEditable(false);
footer=new Font("Dialog",Font.PLAIN,13);
sta.setFont(footer);
jsd=new JScrollPane(sta);
add(jsd,BorderLayout.CENTER);

try{

Class.forName("sun.jdbc.odbc.JdbcOdbcDriver");

String s="jdbc:odbc:Driver={Microsoft Excel Driver (*.xls)};DBQ=C:\\Program Files\\Java\\jdk1.6.0_21\\bin\\jp\\ap\\pra\\word_list_common.xls";

String meaning1=null;
String columnValue=null;
con = DriverManager.getConnection(s);
st = con.createStatement();

	if(ser.length()>2)
{
	

if(ser.endsWith("d"))
{
	ser=sersel.substring(0, sersel.length()-1);
	//System.out.println(ser);
	// ser=sersel;
}
}
	
	//meth 1 condition check
	
	if(ser.startsWith("a")||ser.startsWith("b")||ser.startsWith("c")||ser.startsWith("d")||ser.startsWith("e")||ser.startsWith("f")||ser.startsWith("g"))
	{
if(check==false)
{
rs = st.executeQuery( "Select * from [Sheet0$] where 'word=+ser+' ");
while (rs.next()) 
{
columnValue= rs.getString("word");

if(columnValue.equals(ser))
{

meaning1=rs.getString("meaning1");
check=true;
}

else
{
	check=false;
	
}

}
}
	}
	
	else if(ser.startsWith("t")||ser.startsWith("u")||ser.startsWith("v")||ser.startsWith("w")||ser.startsWith("x")||ser.startsWith("y")||ser.startsWith("z"))
	{
if(check==false)
{
rs = st.executeQuery( "Select * from [Sheet1$] where 'word=+ser+' ");
while (rs.next()) 
{
columnValue= rs.getString("word");

if(columnValue.equals(ser))
{

meaning1=rs.getString("meaning1");
check=true;
}

else
{
	check=false;
	
}

}
}
	}
	
	else
	{

 if(check==false)
{
	rs = st.executeQuery( "Select * from [Sheet2$] where 'word=+ser+' ");
	while (rs.next()) 
	{
	 columnValue= rs.getString("word");
	if(columnValue.equals(ser))
	{
	 meaning1=rs.getString("meaning1");
	 check=true;
	}
	else
	{
		check=false;
		
	}

	}
	
}
	}

 
 //substring operation
 if(meaning1==null)
 {
	 ser=sersel;

// System.out.println(ser);
 if(ser.length()>2)
 {
 	

 if(ser.endsWith("ing"))
 {
 	ser=sersel.substring(0, sersel.length()-3);
 	//System.out.println(ser);
 	// ser=sersel;
 }
 else if(ser.endsWith("ed"))
 {
 	ser=sersel.substring(0, sersel.length()-2);
 	//System.out.println(ser);
 	// ser=sersel;

 }
 else if(ser.endsWith("s"))
 {
 	ser=sersel.substring(0, sersel.length()-1);
 	//System.out.println(ser);
 	// ser=sersel;

 }

 }
 
 
 //substring operation end
 
 
 //method condition checking start
 
 
 if(ser.startsWith("a")||ser.startsWith("b")||ser.startsWith("c")||ser.startsWith("d")||ser.startsWith("e")||ser.startsWith("f")||ser.startsWith("g"))
	{
if(check==false)
{
rs = st.executeQuery( "Select * from [Sheet0$] where 'word=+ser+' ");
while (rs.next()) 
{
columnValue= rs.getString("word");

if(columnValue.equals(ser))
{

meaning1=rs.getString("meaning1");
check=true;
}

else
{
	check=false;
	
}

}
}
	}
	
 
 else if(ser.startsWith("t")||ser.startsWith("u")||ser.startsWith("v")||ser.startsWith("w")||ser.startsWith("x")||ser.startsWith("y")||ser.startsWith("z"))
	{
 
 
 if(check==false)
 {
 rs = st.executeQuery( "Select * from [Sheet1$] where 'word=+ser+' ");
 while (rs.next()) 
 {
 columnValue= rs.getString("word");

 if(columnValue.equals(ser))
 {

 meaning1=rs.getString("meaning1");
 check=true;
 }
 else
 {
 	check=false;
 	
 }

 }
 }
	}
 else
 {

  if(check==false)
 {
 	rs = st.executeQuery( "Select * from [Sheet2$] where 'word=+ser+' ");
 	while (rs.next()) 
 	{
 	 columnValue= rs.getString("word");
 	if(columnValue.equals(ser))
 	{
 	 meaning1=rs.getString("meaning1");
 	check=true;
 	}
 	else
 	{
 		check=false;
 		
 	}

 	}
 	
 }
 }
  
 }
 
 
 
 
 
 
 
 

if(meaning1==null)
{
sta.setText("Sorry!"+"\n"+"Word Not Found"+"\n"+"Suggestion"+"\n"+"Select except Tence (ex: 'ed','ing')");
}

else
{
k=meaning1.length();
StringBuffer bl=new StringBuffer(meaning1);
while(j<k&&(i=bl.indexOf("",i+40))!=-1)
{
j+=40;
bl.replace(i,i,"\n");
}
String sr=bl.toString();
String []seperate=sr.split(";");
if(cou>1)
{
cou=1;
}
for(String pr:seperate)
{
	
sta.append(cou+")\n"+pr+"\n");

++cou;

}
}


//second


//end second


}
catch(Exception ex)
 {

JOptionPane.showMessageDialog(null,ex.getMessage());
	
	System.out.println(ex);

//sta.setText(ex.getMessage());

}

finally
{

//st.close();
//con.close();
//rs.close();
st=null;
con=null;
rs=null;
check=false;

}
}
} 
//english dict connection class end
//tamil dict connection class start



public class Dicta extends JFrame
{
/**
	 * 
	 */
	private static final long serialVersionUID = 1L;
String selectedget1;
TextField tf;
JTextArea sta;
Font footer;
JScrollPane jsd;
String serr=null;
String sersel=null;
public Dicta(String selectedget1)
{
this.selectedget1=selectedget1;
}
public void display()
{
serr=(String)selectedget1.toLowerCase();
sersel=serr;
BorderLayout bdl=new BorderLayout();
setLayout(bdl);
tf=new TextField(selectedget1);
Font header=new Font("Dialog",Font.BOLD,14);
tf.setFont(header);
add(tf,BorderLayout.NORTH);
sta=new JTextArea(10,30);
sta.setEditable(false);
java.awt.Font font=new java.awt.Font("Latha",java.awt.Font.PLAIN,12);
sta.setFont(font);
jsd=new JScrollPane(sta);
add(jsd,BorderLayout.CENTER);

try{
System.out.println("inside tamil");
Class.forName("sun.jdbc.odbc.JdbcOdbcDriver");

String s="jdbc:odbc:Driver={Microsoft Excel Driver (*.xls)};DBQ=C:\\Program Files\\Java\\jdk1.6.0_21\\bin\\jp\\ap\\pra\\English-Tamil dictionary.xls";

String meaning1=null;
String columnValue1=null;
con = DriverManager.getConnection(s);
st = con.createStatement();

System.out.println(serr);	
rs = st.executeQuery( "Select * from [unicode$] where 'word=+serr+' ");
while (rs.next()) 
{
columnValue1= rs.getString("word");

if(columnValue1.equals(serr))
{
	System.out.println(columnValue1);
	meaning1=rs.getString("tamil");
	break;

}


}
System.out.println(meaning1); 
 

if(meaning1==null)
{
sta.setText("Sorry!"+"\n"+"Word Not Found"+"\n"+"Suggestion"+"\n"+"Select except Tence (ex: 'ed','ing')");
}

else
{
	java.awt.Font font1=new java.awt.Font("Latha",java.awt.Font.PLAIN,12);
	sta.setFont(font1);
	sta.setText(meaning1);
}


	
	


//second


//end second


}
catch(Exception ex)
 {

JOptionPane.showMessageDialog(null,ex.getMessage());
	
	System.out.println(ex);

//sta.setText(ex.getMessage());

}

finally
{

//st.close();
//con.close();
//rs.close();
st=null;
con=null;
rs=null;
check=false;

}
}
} 

//tamil dict connection class end



//brow connection class start

class Brow extends JFrame
{
/**
	 * 
	 */
	private static final long serialVersionUID = 1L;
String selectedget;

public Brow(String selectedget)
{
this.selectedget=selectedget;
}

public void display() 
{

BorderLayout blwb=new BorderLayout();
setLayout(blwb);
stat=new JLabel();
jp=new JProgressBar();
jep=new JEditorPane();
jep.setContentType("text/html");
jep.setEditable(false);
JScrollPane js=new JScrollPane(jep);
add(jp,BorderLayout.NORTH);
add(js,BorderLayout.CENTER);
try
{
	jp.setBorderPainted(true);
		
	

	jp.setValue(jp.getValue());
	
	

	jp.setStringPainted(true);
	jp.setString("Loading ...");
 //startTime = new Date().getTime();
//stat.setText("Loading Please wait... ");
jep.setPage("http://www.yourdictionary.com/"+selectedget);


}
catch(IOException e)
{
JOptionPane.showMessageDialog(this,e);
}
/*finally
{
try
{
endTime = new Date().getTime();
Long ti=endTime - startTime;
Thread.sleep(ti);
stat.setText("Success... ");
}
catch (InterruptedException e) {
JOptionPane.showMessageDialog(this,e.getMessage());
}
}*/

}
}
//brow connection classs end




}

//main class end
