<html>
<head>
<title>Sending email using PHP</title>
</head>
<body>
<?php
   $to = "kmanikandangce@gmail.com";
   $subject = "This is subject";
   $message = "This is simple text message.";
   $header = "From:manikandancse2013@gmail.com";
   //ini_set("SMTP","smtp.gmail.com");
   //ini_set("smtp_port","465");
   //ini_set("sendmail_from","manikandancse2013@gmail.com");
   //ini_set("username","manikandancse2013@gmail.com");
   //ini_set("password","ayusha jenufa fathima");
   $retval = mail ($to,$subject,$message,$header);
   if( $retval =true )  
   {
      echo "Message sent successfully...";
   }
   else
   {
      echo "Message could not be sent...";
   }
?>
</body>
</html>