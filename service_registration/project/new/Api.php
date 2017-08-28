<?php
/*
The code is licensed under the MIT License

########################################################################################################
Copyright (C) <2012> Ritesh Chandora <ritesh_chandora@yahoo.co.in>
BLOG :		http://ritesh-chandora.blogspot.in/
FACEBOOK : 	http:www.facebook.com/ritesh.chandora
My Facbook APPs : http://andromeda.nitc.ac.in/~ritesh/fbpending/

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated
documentation files (the "Software"), to deal in the Software without restriction, including without limitation
the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software,
and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions
of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT 
NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT.
IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE
OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

########################################################################################################
Guys here is code written in php for sending sms through your way2sms account.

Guys before using this code make sure that you have installed PHP CURL libraries libcurl. It is necessary for executing this script.

This Code works fine for your small application where you want to send message through your website. Only thing you needed is an account on WAY2SMS . First create an account, then insert this code in your website and pass 4 argument to the function and just sit back and relax :), this code will do automatically everything for you..
enjoy :)

Some points to remember..
1. Some lines are truncated in this webpage so keep track of  double quote("") and new lines.
2. You have to create a normal text file with the name cookie.txt and place it your local host or any folder and set absolute location of cookie file to $cookie_file_path_location variable.
like this  $cookie_file_path_location ="/var/www/sms/cookie.txt"; .
3. Cookie file must have full READ and WRITE permission. Give 777 permission in Linux and full read write permission in windows.
4. Message length must be less than or equal to 140 character.
5. By repeating Code for sending SMS in loop, you can send same message for many time without login and logout.
6. Do not include '0' or '+91' before mobile number.


########################################################################################################
*/


// Hello User just assign all four variable values and open this page from your browser ie page must be in localhost

$userID="9876543210"; //10 digit, way2sms id, from which admin send sms
$userPWD="123456"; // password for user id
$recerverNO="9876543210"; // recever's Number, who is going to receive sms
$message="Anything that you want to send but less than140 character";

//calling the function for sending sms
send_sms($userID,$userPWD,$recerverNO,$message);
echo "Hey your message is deliverd";

//******************** CODE START HERE ********************

function send_sms($userID,$userPWD,$recerverNO,$message)
{
	if(strlen($message)>140) // check for message length
	{echo "message length exceeds 140 characters" ; exit(); }

	$message_urlencode=rawurlencode($message); // message converted into URL encoded form
	$cookie_file_path ="/var/www/oose/cookie.txt";// Cookie file location in your machine with full read and write permission

//START OF Code for getting sessionid
	$url="http://site5.way2sms.com/content/index.html";
	$header_array[0] = "GET /content/index.html HTTP/1.1";
	$header_array[1]= "Host: site5.way2sms.com";
	$header_array[2]= "User-Agent: Mozilla/5.0 (X11; Ubuntu; Linux x86_64; rv:10.0.1) Gecko/20100101 Firefox/10.0.1";
	$header_array[3]= "Accept: text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8";
	$header_array[4]= "Accept-Language: en-us,en;q=0.5";
	$header_array[5]= "Accept-Encoding: gzip,deflate";
	$header_array[6]= "DNT: 1";
	$header_array[7] = "Connection: keep-alive";
	
	$ch = curl_init();					//initialise the curl variable
		curl_setopt($ch, CURLOPT_URL,$url);			//set curl URL for crawling
		curl_setopt($ch, CURLOPT_HTTPHEADER, $header_array);	//set the header for http request to URL 
		curl_setopt($ch, CURLOPT_REFERER, $reffer);		//set reffer url means it shows from where the request is originated.
		curl_setopt($ch, CURLOPT_RETURNTRANSFER, 1);		//it means after crawling data will return
		curl_setopt($ch, CURLOPT_FOLLOWLOCATION, 1);
		curl_setopt($ch, CURLOPT_COOKIEFILE, $cookie_file_path);
		curl_setopt($ch, CURLOPT_COOKIEJAR, $cookie_file_path); // store the return cookie data in cookie file 
	$result = curl_exec ($ch);
	curl_close ($ch);
//END OF Code for getting sessionid

//START OF Code for automatic login and storing cookies
	$post_data = "username=".$userID."&password=".$userPWD."&button=Login";
	$url = "http://site5.way2sms.com/Login1.action";
	$header_array[0]="POST /Login1.action HTTP/1.1";
	$header_array[1]="Host: site5.way2sms.com";
	$header_array[2]="User-Agent: Mozilla/5.0 (X11; Ubuntu; Linux x86_64; rv:10.0.1) Gecko/20100101 Firefox/10.0.1";
	$header_array[3]="Accept: text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8";
	$header_array[4]="Accept-Language: en-us,en;q=0.5";
	$header_array[5]="Accept-Encoding: gzip, deflate";
	$header_array[6]="DNT: 1";
	$header_array[7]="Connection: keep-alive";
	$header_array[8]="Content-Type: application/x-www-form-urlencoded";
	
	$ch = curl_init();
		curl_setopt( $ch, CURLOPT_URL, $url );
		curl_setopt($ch, CURLOPT_POST, true);
		curl_setopt($ch, CURLOPT_POSTFIELDS, $post_data);
		curl_setopt($ch, CURLOPT_HTTPHEADER, $header_array);
		curl_setopt($ch, CURLOPT_COOKIEFILE, $cookie_file_path);
		curl_setopt($ch, CURLOPT_COOKIEJAR, $cookie_file_path);
		curl_setopt( $ch, CURLOPT_FOLLOWLOCATION, true );
		curl_setopt( $ch, CURLOPT_RETURNTRANSFER, true );
		curl_setopt( $ch, CURLOPT_AUTOREFERER, true );
		curl_setopt($ch,CURLOPT_REFERER,"http://site5.way2sms.com/content/index.html");
        $content = curl_exec( $ch );
        $response = curl_getinfo( $ch );
        curl_close ($ch);
//END OF Code for automatic login  and storing cookies

// START OF Code is  getting way2sms unique user ID
	$url = "http://site5.way2sms.com/jsp/InstantSMS.jsp";
	
	$ch = curl_init();
		curl_setopt( $ch, CURLOPT_URL, $url );
		curl_setopt($ch, CURLOPT_COOKIEFILE, $cookie_file_path);
		curl_setopt($ch, CURLOPT_COOKIEJAR, $cookie_file_path);
		curl_setopt( $ch, CURLOPT_RETURNTRANSFER, true );
	$content = curl_exec($ch);
	curl_close ($ch);
	$regex = '/input type="hidden" name="Action" id="Action" value="(.*)"/';
	preg_match($regex,$content,$match);
	$userID = $match[1];
// END OF Code for getting way2sms unique user ID

// START OF Code for sending SMS to Recever
	$post_data = "HiddenAction=instantsms&catnamedis=Birthday&Action=".$userID."&chkall=on&MobNo=".$recerverNO."&textArea=".$message_urlencode."&bulidguid=username&bulidgpwd=*******&bulidyuid=username&bulidypwd=*******&guid1=username&gpwd1=*******&yuid1=username&ypwd1=*******";
	$url = "http://site5.way2sms.com/quicksms.action";
	$header_array[0]="POST /quicksms.action HTTP/1.1";
	$header_array[1]="Host: site5.way2sms.com";
	$header_array[2]="User-Agent: Mozilla/5.0 (X11; Ubuntu; Linux x86_64; rv:10.0.1) Gecko/20100101 Firefox/10.0.1";
	$header_array[3]="Accept: text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8";
	$header_array[4]="Accept-Language: en-us,en;q=0.5";
	$header_array[5]="Accept-Encoding: gzip, deflate";
	$header_array[6]="DNT: 1";
	$header_array[7]="Connection: keep-alive";
	$header_array[8]="Content-Type: application/x-www-form-urlencoded";
	
	$ch = curl_init();
		curl_setopt( $ch, CURLOPT_URL, $url );
		curl_setopt($ch, CURLOPT_POST, true);
		curl_setopt($ch, CURLOPT_POSTFIELDS, $post_data);
		curl_setopt($ch, CURLOPT_HTTPHEADER, $header_array);
		curl_setopt($ch, CURLOPT_COOKIEFILE, $cookie_file_path);
		curl_setopt($ch, CURLOPT_COOKIEJAR, $cookie_file_path);
		curl_setopt( $ch, CURLOPT_FOLLOWLOCATION, true );
		curl_setopt( $ch, CURLOPT_RETURNTRANSFER, true );
		curl_setopt( $ch, CURLOPT_AUTOREFERER, true );
		curl_setopt($ch,CURLOPT_REFERER,"Referer: http://site5.way2sms.com/jsp/InstantSMS.jsp");
	$content = curl_exec( $ch );
	$response = curl_getinfo( $ch );
	curl_close ($ch);
// END OF Code for sending SMS to Recever


}// end function send_sms



//******************** CODE END HERE ********************
?>
