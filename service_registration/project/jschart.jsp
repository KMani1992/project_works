<jsp:useBean id="zz" scope="session" class="javaside.Rbl.jspChart" />
<% 
       // Declarations
       int iW, iH   ; // Image size
       int iColor   ; // background Color
       int iPres    ; // Presentation
       boolean b1   ; // Legend 
       boolean b2   ; // Bullet 
       String sFormat   ; // Format (gif/png) 

       // get all parameters
       String t = null ; 
       t = request.getParameter("width") ; 
       if (t == null) 
          iW = 400 ; 
       else 
          iW = java.lang.Integer.parseInt(t) ; 

       t = request.getParameter("height") ; 
       if (t == null) 
          iH = 350 ; 
       else 
          iH = java.lang.Integer.parseInt(t) ; 

       t = request.getParameter("color") ; 
       if (t == null) 
          iColor = -1 ; 
       else 
          iColor = java.lang.Integer.parseInt(t, 16) ; 

       t = request.getParameter("pres") ; 
       if (t == null) 
          iPres = 1 ; 
       else 
          iPres = java.lang.Integer.parseInt(t) ; 

       t = request.getParameter("format") ; 
       if (t == null) 
          sFormat = "gif" ; 
       else 
          sFormat = t ; 

       t = request.getParameter("b1") ; 
       if (t == null) 
          b1 = false ; 
       else 
          b1 = t.equalsIgnoreCase("on") ; 

       t = request.getParameter("b2") ; 
       if (t == null) 
          b2 = false ; 
       else 
          b2 = t.equalsIgnoreCase("on") ; 


       // Init image and size
       zz.init(iW, iH) ; 

       // Define Font used
       zz.setFontA("Dialog", 0, 8) ; 
       zz.setFontTitre("Dialog", 3, 10) ; 
       zz.setFontLegend("Dialog", 0, 8) ; 

       // Define  cols
       zz.setCol(2) ; 
       zz.addCol(0, 55255, "Tretis") ; 
       zz.addCol(1, 255,   "Lighoas") ; 

       // Define title and legends
       zz.setTitle("--------------           Test acxChart JSP") ; 
       zz.setLegend("Week 42/2000 ", "Number inc."); 

       zz.setRotate(true); 
       zz.setBkColor( iColor ); 

       // Define all datas
       zz.addRow("Lun . ; 25 ; 32 ; "); 
       zz.addRow("Mar . ; 15 ; 21 ;"); 
       zz.addRow("Mer . ; 21 ; 21 ;"); 
       zz.addRow("Jeu . ; 16 ; 14 ;"); 
       zz.addRow("Ven . ; 12 ; 16 ;"); 
       zz.addRow("Sam . ; 15 ; 16 ;"); 
       zz.addRow("Dim . ; 15 ; 17 ;"); 
       // fin des donnees

       // Presenation type
       zz.setPress(iPres); 
       zz.setOrigine( 40, 50) ; 
       zz.setXPress(b1, b2, false); 

       // Build image
       zz.build(true) ; 

       response.reset(); 
       response.setContentType("image/" + sFormat ); 
       response.addHeader("Content-Disposition","filename=acx." + sFormat); 

       if (sFormat.equalsIgnoreCase("png")) 
          response.getOutputStream().write(zz.getImage(1)); 
       else 
          response.getOutputStream().write(zz.getImage(0)); 

       response.flushBuffer(); 

       // Free resources
       zz.clear() ; 
%>