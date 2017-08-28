import java.awt.*;
import java.awt.event.*;
import javax.swing.*;

public class Operation extends JFrame
{
JButton process;
JTextArea jta;
JPanel p;
JLabel jl1;
JLabel jl2;
JLabel jl3;
JLabel jl4;
JComboBox jcb;
JTextField jt1,jt2;
Operation()
{

BorderLayout bl=new BorderLayout();
setLayout(bl);
p=new JPanel();
jl1=new JLabel("No of Rows");
jt1=new JTextField(5);

jt1.setToolTipText("Enter Maximum no of Rows ( e.g:10 )");
p.add(jl1);
p.add(jt1);
jl2=new JLabel("Table operand");
jt2=new JTextField(5);

jt2.setToolTipText("Enter operand ( e.g:2 )");

p.add(jl2);
p.add(jt2);

jl3=new JLabel("Select operator");

jcb = new JComboBox();
jcb.addItem("Multiplication");

jcb.addItem("Addition");

jcb.addItem("Subtraction");

p.add(jl3);
p.add(jcb);


process=new JButton("Process");
process.setToolTipText("Tabulation");
p.add(process);
jl4=new JLabel("© KMK");

jl4.setToolTipText("kmanikandangce@gmail.com");
p.add(jl4);
jta=new JTextArea();
Font header=new Font("Dialog",Font.BOLD,16);
jta.setFont(header);
jta.setEditable(false);
JScrollPane js=new JScrollPane(jta);
add(p,BorderLayout.NORTH);

add(js,BorderLayout.CENTER);

ItemHandle handle=new ItemHandle(process);

process.addActionListener(handle);

}

 
class ItemHandle implements ActionListener
{
JButton process;
public ItemHandle(JButton process)
{
this.process=process;
}

String oper="";
int result,i;
public void actionPerformed(ActionEvent ae)
{

jta.setText("");
String rows = jt1.getText();
int a=Integer.parseInt(rows);

String operand = jt2.getText();
int b=Integer.parseInt(operand);
String operator= (String)jcb.getSelectedItem();




if(operator=="Multiplication")
{

oper="*";
for(i=0;i<=a;i++)
{

result=i*b;

jta.append("                                                      "+i+"      "+"      "+oper+"      "+b+"            "+"="+"      "+result+"\n");

}
 

}
if(operator=="Addition")
{
oper="+";
for(i=0;i<=a;i++)
{

result=i+b;
 
jta.append("                                                      "+i+"     "+"      "+oper+"      "+b+"            "+"="+"      "+result+"\n");

}
}
 if(operator=="Subtraction")
{
oper="-";
for(i=0;i<=a;i++)
{

result=i-b;

jta.append("                                                      "+i+"      "+"      "+oper+"      "+b+"       "+"="+"      "+result+"\n");

}
}

//JOptionPane.showMessageDialog(null,oper);






}
}
}