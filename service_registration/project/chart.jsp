<%// required packages  %>
<%@ page import="java.awt.Image" %>
<%@ page import="java.awt.*"%>
<%@ page import="java.text.SimpleDateFormat"%>
<%@ page import="java.awt.BasicStroke"%>
<%@ page import ="org.jfree.ui.ApplicationFrame"%>
<%@ page import="java.io.*" %>
<%@ page import="java.io.File"%>
<%@ page import="org.jfree.chart.*" %>
<%@ page import="org.jfree.chart.axis.*" %>
<%@ page import="org.jfree.chart.entity.*" %>
<%@ page import="org.jfree.chart.labels.*" %>
<%@ page import="org.jfree.chart.plot.*" %>
<%@ page import="org.jfree.chart.renderer.category.*" %>
<%@ page import="org.jfree.chart.urls.*" %>
<%@ page import="org.jfree.data.category.*" %>
<%@ page import="org.jfree.data.general.*" %>
<%@ page import="org.jfree.data.time.Minute"%>
<%@ page import="org.jfree.data.time.Hour"%>
<%@ page import="org.jfree.data.time.TimeSeries"%>
<%@ page import="org.jfree.data.time.TimeSeriesCollection"%>
<%@ page import="org.jfree.data.xy.XYDataset"%>
<%@ page import="org.jfree.chart.plot.XYPlot"%>
<%@ page import="org.jfree.chart.renderer.xy.StandardXYItemRenderer"%>
<%@ page import="org.jfree.chart.renderer.xy.XYItemRenderer"%>
 <%@ page import=  "java.sql.Connection" %>
<%@ page import  ="java.sql.DriverManager" %>
<%@ page import = "java.sql.SQLException" %>
<%@ page import = "java.sql.PreparedStatement" %>
<%@ page import = "java.sql.ResultSet" %>
<%@ page import = "java.sql.Statement" %>
 <%@ page import=  "javax.servlet.*" %>
<%@ page import  ="javax.servlet.http.*" %>

<%@ page import="java.awt.image.BufferedImage"%>
<%
 try
 {
 File image = File.createTempFile("image", "tmp");

 //chart class instance
Fms fm = new Fms("Graph");

JFreeChart chart = fm.createChart(fm.dataset);
 ChartUtilities.saveChartAsPNG(image, chart, 500, 400);
//get input stream
 FileInputStream fileInStream = new FileInputStream(image);
//output stream foe returning chart as image
 OutputStream outStream = response.getOutputStream();
 long fileLength;
 byte[] byteStream;
 fileLength = image.length();
 byteStream = new byte[(int)fileLength];
//read chart image
 fileInStream.read(byteStream, 0, (int)fileLength);
//returns chart image whenever called
 response.setContentType("image/png");
 response.setContentLength((int)fileLength);
 response.setHeader("Cache-Control","no-store,no-cache, must-revalidate, post-check=0, pre-check=0");
 response.setHeader("Pragma", "no-cache");
 fileInStream.close();
 outStream.write(byteStream);
 outStream.flush();
 outStream.close();
 }
 catch (IOException e)
 {
 System.err.println("Problem occurred creating chart.");
 }
%>
<%! public class Fms extends ApplicationFrame {  
//Main class
   XYDataset dataset= null;
   public Fms(final String title) {
        super(title);
      dataset= createDataset();
        final JFreeChart chart = createChart(dataset);
        final ChartPanel chartPanel = new ChartPanel(chart);
        chartPanel.setPreferredSize(new java.awt.Dimension(700, 570));
        chartPanel.setMouseZoomable(true, false);
        setContentPane(chartPanel);
    }
//chart creation method
   JFreeChart createChart(final XYDataset dataset) {
        final JFreeChart chart = ChartFactory.createTimeSeriesChart(
            "Speed Chart",
            "Time",
            "Speed",
            dataset,
            true,
            true,
            false
        );
        chart.setBackgroundPaint(Color.white);
       final XYPlot plot = chart.getXYPlot();
        plot.setBackgroundPaint(Color.lightGray);
        plot.setDomainGridlinePaint(Color.white);
        plot.setRangeGridlinePaint(Color.white);
        plot.setDomainCrosshairVisible(true);
        plot.setRangeCrosshairVisible(false);
        final XYItemRenderer renderer = plot.getRenderer();
        if (renderer instanceof StandardXYItemRenderer) {
            final StandardXYItemRenderer rr = (StandardXYItemRenderer) renderer;
            rr.setShapesFilled(true);
            renderer.setSeriesStroke(0, new BasicStroke(1.0f));
            renderer.setSeriesStroke(1, new BasicStroke(1.0f));
           }      
        final DateAxis axis = (DateAxis) plot.getDomainAxis();
        axis.setDateFormatOverride(new SimpleDateFormat("dd:MM"));
        try{
        final ChartRenderingInfo info = new ChartRenderingInfo
(new StandardEntityCollection());
final File file1 = new File("c:/Documents and Settings/accounts/WebApplication2/web/barchart.png");
ChartUtilities.saveChartAsPNG(file1, chart, 600, 400, info);
        }catch(Exception e){}
        return chart;
    }  
//data set generation method
    private XYDataset createDataset() {
        final TimeSeriesCollection dataset = new TimeSeriesCollection();
        dataset.setDomainIsPointsInTime(true);      
        final TimeSeries s1 = new TimeSeries("Series 1", Minute.class);
         int str = 0;
         int i =0,j= 0 ;
         String str1 = null;
        try{            
     Class.forName("sun.jdbc.odbc.JdbcOdbcDriver");
String ss="jdbc:odbc:Driver={Microsoft Access Driver (*.mdb)};DBQ=C:\\Program Files\\Apache Software Foundation\\Tomcat 6.0\\webapps\\project\\Database.mdb";
Connection connection=DriverManager.getConnection(ss);
//Statement st=con.createStatement();
Statement statement = connection.createStatement();

ResultSet re=statement.executeQuery("select * from details where vehiclenumber='tni435'");
while(re.next())
{
         str1= "12"
         String sa = str1.substring(11,13);
         String ha = str1.substring(14,16);
        str="123"
        j=Integer.parseInt(sa);
        i=Integer.parseInt(ha);
        String date = "12"
        String y = date.substring(0,4);
         String m = date.substring(5,7);
          String d = date.substring(8,10);
         s1.add(new Minute(i, j, Integer.parseInt(d), Integer.parseInt(m), Integer.parseInt(y)), str);
          }
          }
          catch(Exception e)
          {            
          }
         System.out.println(str1.substring(11,13));
          System.out.println(str1.substring(14,16)+"\t"+str1);                
        dataset.addSeries(s1);  
        return dataset;
    }
    }
%>



HTML Code for calling this JSP file
exp.jsp is the name of above jsp code file in my application
<html>
<body>
<img src="exp.jsp" alt="Progress chart" />
</body>
</html>