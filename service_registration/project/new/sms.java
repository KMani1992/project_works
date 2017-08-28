package way2sms;

import java.net.URLEncoder;
import java.util.ArrayList;

public class Credentials {
 private ArrayList<String> list = new ArrayList<String>();

 public void set(String name, String value) {
  StringBuilder buffer = new StringBuilder();

  buffer.append(name);
  buffer.append("=");
  buffer.append(getUTF8String(value));

  add(buffer.toString());
 }

 public void append(String name, String value) {
  StringBuilder buffer = new StringBuilder();

  buffer.append("&");
  buffer.append(name);
  buffer.append("=");
  buffer.append(getUTF8String(value));

  add(buffer.toString());
 }

 private void add(String item) {
  list.add(item);
 }

 private String getUTF8String(String value) {
  String encodedValue = null;

  try {
   encodedValue = URLEncoder.encode(value, "UTF-8");
  } catch(Exception exception) {
   System.err.println("Encoding error");
  }

  return encodedValue;
 }

 public boolean isEmpty() {
  return list.isEmpty();
 }

 public void reset() {
  list.clear();
 }

 public String getUserCredentials() {
  StringBuilder buffer = new StringBuilder();
  int size = list.size();

  for(int i = 0; i < size; i++)
   buffer.append(list.get(i));

  return buffer.toString();
 }
}

//url connector
package way2sms;
 
import java.io.BufferedReader;
import java.io.DataOutputStream;
import java.io.InputStream;
import java.io.InputStreamReader;
import java.net.HttpURLConnection;
import java.net.Proxy;
import java.net.URL;
 
public class URLConnector {
 private static HttpURLConnection connection;
 private static Proxy proxy;
 
 public static void setProxy(String host, int port) {
  proxy = new Proxy(Proxy.Type.HTTP, java.net.InetSocketAddress.createUnresolved(host, port));
 }
 
 public static void connect(String urlPath, boolean redirect, String method, String cookie, String credentials) {
  try {
   URL url = new URL(urlPath);
   
   if(null != proxy)
    connection = (HttpURLConnection) url.openConnection(proxy);
   else
    connection = (HttpURLConnection) url.openConnection();
 
   connection.setInstanceFollowRedirects(redirect);
 
   if(cookie != null)
    connection.setRequestProperty("Cookie", cookie);
 
   if(method != null && method.equalsIgnoreCase("POST")) {
    connection.setRequestMethod(method);
    connection.setRequestProperty("Content-Type", "application/x-www-form-urlencoded");    
   }
 
   connection.setRequestProperty("User-Agent", "Mozilla/5.0 (Windows NT 6.1; WOW64; rv:10.0.4) Gecko/20100101 Firefox/10.0.4"); 
 
   connection.setUseCaches (false);
   connection.setDoInput(true);
   connection.setDoOutput(true);
 
   if(credentials != null) {
    DataOutputStream wr = new DataOutputStream (connection.getOutputStream ());
    wr.writeBytes (credentials);
    wr.flush ();
    wr.close ();
   }
  } catch(Exception exception) {
   System.out.println("Connection error");
  }
 }
 
 public static String getCookie() {
  String cookie = null;
 
  if(connection != null) {
   String headerName=null;
 
   for (int i = 1; (headerName = connection.getHeaderFieldKey(i)) != null; i++) {
    if (headerName.equals("Set-Cookie")) {
     cookie = connection.getHeaderField(i).split(";")[0];
     break;
    }
   }
  }
 
  return cookie;
 }
 
 public static String getLocation() {
  String location = null;
 
  if(connection != null) {
   String headerName=null;
 
   for (int i = 1; (headerName = connection.getHeaderFieldKey(i)) != null; i++) {
    if (headerName.equals("Location")) {
     location = connection.getHeaderField(i).split(";")[0];
     break;
    }
   }
  }
 
  return location;
 }
 
 public static int getResponseCode() {
  int responseCode = -1;
 
  if(connection != null) {
   try {
    responseCode = connection.getResponseCode();
   } catch(Exception exception) {
    System.err.println("Response code error");
   }
  }
 
  return responseCode;
 }
 
 public static String getResponse() {
  StringBuilder response = new StringBuilder();
 
  if(connection != null) {
   try {
    InputStream is = connection.getInputStream();
    BufferedReader rd = new BufferedReader(new InputStreamReader(is));
 
    String line;
    while((line = rd.readLine()) != null) {
     response.append(line);
     response.append('\r');
    }
 
    rd.close();
   } catch(Exception exception) {
    System.err.println("Response error");
   }
  }
 
  return response.toString();
 }
 
 public static String getErrorMessage() {
  StringBuilder errorMessage = new StringBuilder();
 
  if(connection != null) {
   try {
    InputStream es = connection.getErrorStream();
    BufferedReader rd = new BufferedReader(new InputStreamReader(es));
 
    String line;
    while((line = rd.readLine()) != null) {
     errorMessage.append(line);
     errorMessage.append('\r');
    }
 
    rd.close();
   } catch(Exception exception) {
    System.err.println("Error in getting error message");
   }
  }
 
  return errorMessage.toString();
 }
 
 public static void disconnect() {
  if(connection != null)
   connection.disconnect();
 }
}

//Way2Sms (entry point)
package way2sms;
  
import java.net.HttpURLConnection;
  
public class Way2Sms {
 private static int responseCode = -1;
 private static String userCredentials = null;
 private static String cookie = null;
 private static String site = null;
 private static String actionStr = null;
 private static Credentials credentials = new Credentials();
  
 public static void main(String[] args) {
  //setProxy("127.0.0.1", 8080);
  login("your mobile no.", "password");
  sendSMS("receivers mobile no.", "message");
  //sendSMS(new String[] { "receivers mobile no. 1", "receivers mobile no. 2", "..." }, "message");
  System.out.println("Message has been sent successfully!");
 }
  
 private static void setProxy(String host, int port) {
  URLConnector.setProxy(host, port);
 }
  
 private static void getSite() {
  URLConnector.connect("http://www.way2sms.com/", false, "GET", null, null);
  responseCode = URLConnector.getResponseCode();
  if(responseCode != HttpURLConnection.HTTP_MOVED_TEMP && responseCode != HttpURLConnection.HTTP_OK)
   exit("getSite failed!");
  else {
   site = URLConnector.getLocation();
   if(site != null)
    site = site.substring(7, site.length() - 1);
  }
  URLConnector.disconnect();
 }
  
 private static void preHome() {
  URLConnector.connect("http://" + site + "/content/prehome.jsp", false, "GET", null, null);
  responseCode = URLConnector.getResponseCode();
  if(responseCode != HttpURLConnection.HTTP_MOVED_TEMP && responseCode != HttpURLConnection.HTTP_OK)
   exit("preHome failed");
  else
   cookie = URLConnector.getCookie();
  URLConnector.disconnect();
 }
  
 private static void login(String uid, String pwd) {
  getSite();
  preHome();
  
  String location = null;
  
  credentials.set("username", uid);
  credentials.append("password", pwd);
  credentials.append("button", "Login");
  userCredentials = credentials.getUserCredentials();
  
  URLConnector.connect("http://" + site + "/Login1.action", false, "POST", cookie, userCredentials);
  responseCode = URLConnector.getResponseCode();
  if(responseCode != HttpURLConnection.HTTP_MOVED_TEMP && responseCode != HttpURLConnection.HTTP_OK)
   exit("authentication failed!");
  else
   location = URLConnector.getLocation();
  URLConnector.disconnect();
  
  URLConnector.connect(location, false, "GET", cookie, null);
  responseCode = URLConnector.getResponseCode();
  if(responseCode != HttpURLConnection.HTTP_MOVED_TEMP && responseCode != HttpURLConnection.HTTP_OK)
   exit("redirection failed!");
  URLConnector.disconnect();
 }
  
 private static void getActionString() {
  URLConnector.connect("http://" + site + "/jsp/InstantSMS.jsp", false, "GET", cookie, null);
  responseCode = URLConnector.getResponseCode();
  if(responseCode == HttpURLConnection.HTTP_MOVED_TEMP || responseCode == HttpURLConnection.HTTP_OK) {
   String str = URLConnector.getResponse();
  
   String aStr = "name=\"Action\" id=\"Action\"";
   int aStrLen = aStr.length();
  
   int index = str.indexOf(aStr);
   if(index > 0) {
    str = str.substring(index + aStrLen);
    index = str.indexOf("\"");
    if(index > 0) {
     str = str.substring(index + 1);
     index = str.indexOf("\"");
     if(index > 0)
      actionStr = str.substring(0, index);
    }
   }
  } else
   exit("getActionString failed!");
  URLConnector.disconnect();
 }
  
 private static void sendSMS(String receiversMobNo, String msg) {
  getActionString();
  
  credentials.reset();
  credentials.set("HiddenAction", "instantsms");
  credentials.append("catnamedis", "Birthday");
  if(actionStr != null)
   credentials.append("Action", actionStr);
  else
   exit("Action string missing!");
  credentials.append("chkall", "on");
  credentials.append("MobNo", receiversMobNo);
  credentials.append("textArea", msg);
  
  userCredentials = credentials.getUserCredentials();
  
  URLConnector.connect("http://" + site + "/quicksms.action", true, "POST", cookie, userCredentials);
  responseCode = URLConnector.getResponseCode();
  if(responseCode != HttpURLConnection.HTTP_MOVED_TEMP && responseCode != HttpURLConnection.HTTP_OK)
   exit("sendSMS failed!");
  URLConnector.disconnect();
 }
 
 private static void sendSMS(String[] receiversMobNos, String msg) {
 int noOfReceivers = receiversMobNos.length;
 
 for(int i = 0; i < noOfReceivers; i++)
  sendSMS(receiversMobNos[i], msg);
 }
  
 private static void exit(String errorMsg) {
  System.err.println(errorMsg);
  System.exit(1);
 }
}