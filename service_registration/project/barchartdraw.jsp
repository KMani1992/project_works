<%@ page contentType="image/jpeg" import="java.awt.*,java.awt.image.*,com.sun.image.codec.jpeg.*,java.util.*"%>

<%
// Create image
//g.setBackground(Color.white);
String rec1=request.getParameter("batt");
String rec2=request.getParameter("engg");
String rec3=request.getParameter("suss");
String rec4=request.getParameter("bree");
String rec5=request.getParameter("extt");
String rec6=request.getParameter("tyrr");
String rec7=request.getParameter("elcc");
String rec8=request.getParameter("sett");
String rec9=request.getParameter("ovee");
String valv[]=new String[9];
valv[0]=rec1;
valv[1]=rec2;
valv[2]=rec3;
valv[3]=rec4;
valv[4]=rec5;
valv[5]=rec6;
valv[6]=rec7;
valv[7]=rec8;
valv[8]=rec9;
int kil1=Integer.parseInt(rec1);
int kil2=Integer.parseInt(rec2);
int kil3=Integer.parseInt(rec3);
int kil4=Integer.parseInt(rec4);
int kil5=Integer.parseInt(rec5);
int kil6=Integer.parseInt(rec6);
int kil7=Integer.parseInt(rec7);
int kil8=Integer.parseInt(rec8);
int kil9=Integer.parseInt(rec9);

//out.println(kil);

int val[]=new int[9];
val[0]=kil1;
val[1]=kil2;
val[2]=kil3;
val[3]=kil4;
val[4]=kil5;
val[5]=kil6;
val[6]=kil7;
val[7]=kil8;
val[8]=kil9;

///out.println(val[0]);
//String rec2=request.getParameter("eng");

int width=590, height=570;
int ls=50;
int i=0,j=0,ii=0,q=0;
String day[]={"10","20","30","40","50","60","70","80","90","100"};
String con[]={"Battery","Engine","Suspension","Brakes","Exterior","Tyres","Electrical","Seats","Overall",""};
int x=10;
int y=90;
String s="parts condition %";
int v1=0;
int v;

BufferedImage image = new BufferedImage(width,
height, BufferedImage.TYPE_INT_RGB);
// Get drawing context
Graphics g = image.getGraphics();
// Fill background
//g.fillBackground(Color.white);
g.setColor(Color.white);
g.setFont(new Font("Dialog", Font.PLAIN, 22));
g.drawString("Your Bike Parts Status",190,30);
g.setFont(new Font("Dialog", Font.PLAIN, 12));

g.setColor(Color.cyan);

g.drawLine(ls, 60, ls, 470);
g.drawLine(ls, 470, 570, 470);
int stx=30;

for(i=370;i>0;i=i-40)

{
if(j==9)
{
stx=25;
}
g.drawLine(40, i+70, 50, i+70);

g.drawString(day[j],stx,i+50);
j++;
}

for(ii=70;ii<=550;ii=ii+60)

{
if(val[q]>=99)
{
g.setColor(new Color(182,225,48));

}
else if(val[q]>=78)
{
g.setColor(new Color(70,188,216));
}
else if(val[q]>=60)
{
g.setColor(new Color(239,218,51));
}
else if(val[q]>=40)
{
g.setColor(new Color(247,44,135));
}

int lv=val[q]*4;


//g.fillRect(ii, 470-lv, 15, 350);

g.fill3DRect(ii, 460-lv, 15, lv+10,true);
g.setColor(Color.white);
g.draw3DRect(ii, 460-lv, 15, lv+10,true);
g.setColor(new Color(0,24,66));
g.drawOval(ii-10, 435-lv, 35,25);
g.setColor(new Color(0,51,153));
g.fillOval(ii-10, 435-lv, 35,25);
g.setColor(Color.white);

//String kil=String.parseString(val[q]);
g.drawString(valv[q],ii, 453-lv);
g.setColor(Color.cyan);
if(con[q]=="Brakes")
{
g.drawString(con[q],ii,485);
}
else
{

g.drawString(con[q],ii-10,485);
}
q++;
}


g.setColor(Color.cyan);
v=20;
int k=s.length();

g.setFont(new Font("Dialog", Font.PLAIN, 18));
while(v1<k+1)
{

if(v1==k)
g.drawString(s.substring(v1),x,y+(v1*v));
else
g.drawString(s.substring(v1,v1+1),x,y+(v1*v));
v1++;
}
int wih=510;
g.setFont(new Font("Dialog", Font.PLAIN, 14));
g.setColor(new Color(182,225,48));
g.fillRect(100, wih, 25, 20);
g.setColor(Color.white);
g.drawString("Excellent",135,wih+15);
g.setColor(new Color(70,188,216));
g.fillRect(200, wih, 25, 20);
g.setColor(Color.white);
g.drawString("Good",235,wih+15);
g.setColor(new Color(239,218,51));
g.fillRect(300, wih, 25, 20);
g.setColor(Color.white);
g.drawString("Normal",335,wih+15);
g.setColor(new Color(247,44,135));
g.fillRect(400, wih, 25, 20);
g.setColor(Color.white);
g.drawString("Bad",435,wih+15);

g.drawString("DuraiRaj Auto Works",235,wih+45);

g.setFont(new Font("Dialog", Font.PLAIN, 10));

g.drawString("Press back button to your Profile",440,wih+55);
//alert("ss");


//g.setColor(Color.cyan);

// Dispose context
g.dispose();
// Send back image
ServletOutputStream sos = response.getOutputStream();
JPEGImageEncoder encoder =
JPEGCodec.createJPEGEncoder(sos);
encoder.encode(image);


%>



