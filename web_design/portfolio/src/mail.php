<!doctype html>
<html>
<head>
<meta charset="utf-8">
<meta http-equiv="refresh" content="5; URL=contact_enquiry.html"/>
<title>:: kmanikandangce portfolio ::</title>

<link rel="icon" type="image/png" href="favicon.ico" />

<link rel="stylesheet" href="css/bootstrap.css"/>
<link rel="stylesheet" href="css/bootstrap-theme.css"/>
<link rel="stylesheet" href="css/master_style.css"/>
<!--[if lt IE 9]>	
    <script type="text/javascript">	
    	document.createElement("header");
        document.createElement("nav");
        document.createElement("section");
        document.createElement("footer");
    </script>    
<![endif]-->
</head>

<body>
<?php	
		$name = $_POST['name'];
		$email = $_POST['email'];
		$message = $_POST['message'];		
		$subj = $_POST['subj'];
		$phone = intval($_POST['phone']);
		$from = 'KmanikandanGCE Portfolio'; 
		$to = 'kmanikandangce@gmail.com'; 
		$subject = 'Message From KmanikandanGCE Portfolio';
		
		$body ="From: $name\n E-Mail: $email\n Phone:\n $phone Subject:\n $subj Message:\n $message";
		
		if (mail ($to, $subject, $body, $from)) {

		
		echo('<div class="alert alert-success"><p>I Received Your Enquiry. I will get back to you soon..., Thank You.</p></div>');
	} else {
		echo('<div class="alert alert-danger"><p>Sorry there was an error sending your message. Please try again later.</p></div>');
	}
	
	
?>

<script type="text/javascript">
$(document).ready(function(){
$( "div" ).last().css( "display", "none" );
});
</script>

</body>
</html>