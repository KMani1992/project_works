<%@ page contentType="image/jpeg"
import="java.awt.*,java.awt.image.*,
com.sun.image.codec.jpeg.*,java.util.*"
%>
<%
// Create image
int width=200, height=210;
BufferedImage image = new BufferedImage(width,height, BufferedImage.TYPE_INT_RGB);
// Get drawing context
Graphics g = image.getGraphics();
// Fill background
g.setColor(Color.white);
g.fillRect(20, 20, 10, 200);
g.setColor(Color.cyan);
g.drawLine(0, 0, 0, 200);
g.drawLine(0, 200, 200, 200);
// Create random polygon
//Polygon poly = new Polygon();
//Random random = new Random();

// Fill polygon
g.setColor(Color.cyan);
//g.fillPolygon(poly);
// Dispose context
g.dispose();
// Send back image
ServletOutputStream sos = response.getOutputStream();
JPEGImageEncoder encoder =JPEGCodec.createJPEGEncoder(sos);
encoder.encode(image);
%>