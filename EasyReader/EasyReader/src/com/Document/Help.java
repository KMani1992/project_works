package com.Document;

import java.awt.*;

import javax.swing.*;
import javax.swing.JFrame;
import javax.swing.JTextArea;


public class Help extends JFrame
{
/**
	 * 
	 */
	private static final long serialVersionUID = 1L;
JTextArea text;
public Help()
{


String s="\nWhat is easy Reader ?"+"\n\n"+

"  EasyReader is a basic text-Readding program and it's most commonly used to know the offline or Onlin Dictionary meaning of Reading text files.A text file is a file type typically identified by the .txt file name extension."+"\n\n"+

"How to Use ?"+"\n\n"+

" For Offline Dictionary :"+"\n"+

"  Select the Word and Double Click the mouse, the popup window will show the meaning of the word."+"\n\n"+

" For Online Dictionary :"+"\n"+

"  Select the Word and Right Click the mouse, the popup menu will show the option and then you choose OnlineDict option the popup Browser window will show the meaning of the word."+"\n\n"+ 
 
"For take a Notes :"+"\n"+

" click the File menu, and then click Notes option the popup window will show the editer panel after Writing Note Click the Close Button to Save the Notes.\n";

text = new JTextArea(s);
text.setLineWrap(true);
text.setEditable(false);
Font ft=new Font("Dialog",Font.PLAIN,14);
text.setFont(ft);
JScrollPane js=new JScrollPane(text);
add(js);






}
}