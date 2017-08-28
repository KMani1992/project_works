package com.Document;

import java.awt.event.*;
import java.awt.*;
import javax.swing.*;
import javax.swing.JFrame;

import java.io.*;
import javax.swing.JOptionPane;
import java.util.Date;
public class Writer extends JFrame 
{

/**
	 * 
	 */
	private static final long serialVersionUID = 1L;
JScrollPane jsw;
JTextArea jtaw;
public Writer()
{

MyWindowAdapter adapter=new MyWindowAdapter(this);
addWindowListener(adapter);
BorderLayout blw=new BorderLayout();
setLayout(blw);
jtaw=new JTextArea();
Font fta=new Font("Dialog input",Font.ITALIC,14);
jtaw.setFont(fta);
jsw=new JScrollPane(jtaw);
add(jsw,BorderLayout.CENTER);

}

class MyWindowAdapter extends WindowAdapter
{
Writer write;
public MyWindowAdapter(Writer write)
{
this.write=write;
}
public void windowClosing(WindowEvent we)
{


try
{
Date date=new Date();
FileWriter out = new FileWriter("Notes.txt",true);
BufferedWriter writer = new BufferedWriter(out);

String s1=jtaw.getText();
String s2=s1+"\n"+"--------------"+date+"--------------";
String s3=s2.replaceAll("\n","\r\n");




//writer.append(s2+"\n");

//writer.newLine();
writer.write(s3);
writer.newLine();
writer.close();





/*
BufferedWriter buw=new BufferedWriter(new FileWriter("Notes.txt",true));
Date date=new Date();
String s1=jtaw.getText();


String s2=s1.replaceAll("\n","\r\n");
//String s3=s2.concat("\n");
String s4=s2+"\n"+"--------------"+date+"--------------";

//buw.append(s2+"\n");






buw.write(s4);
buw.close();

*/



}
catch(IOException e)
{

JOptionPane.showMessageDialog( null, e );

}

}

}
}
