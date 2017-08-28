package com.Document;

import java.awt.*;

import javax.swing.*;
import javax.swing.JFrame;
import javax.swing.JTextArea;


public class About extends JFrame
{
/**
	 * 
	 */
	private static final long serialVersionUID = 1L;
JTextArea tex;
JScrollPane js;
public About()
{
Font ft=new Font("Dialog",Font.PLAIN,14);
String s="\n About Easyreader:"+"\n"+
"            This Program was Developed by "+"\n"+
"  K.MANIKANDAN, CSE Dept Student of"+"\n"+
"  Government College of Engineering"+"\n"+
"  Tirunelveli -7."+"\n\n"+

" Contact:"+"\n"+

"          kmanikandangce@gmail.com";

tex=new JTextArea(s,10,40);
tex.setEditable(false);
tex.setFont(ft);
js=new JScrollPane(tex);
add(js);



}
}