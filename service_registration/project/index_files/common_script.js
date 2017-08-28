/*
	Standards Compliant Rollover Script
	Author : Daniel Nolan
	http://www.bleedingego.co.uk/webdev.php
*/

function initRollovers() {
	if (!document.getElementById) return
	
	var aPreLoad = new Array();
	var sTempSrc;
	var aImages = document.getElementsByTagName('img');

	for (var i = 0; i < aImages.length; i++) {		
		if (aImages[i].className == 'imgover') {
			var src = aImages[i].getAttribute('src');
			var ftype = src.substring(src.lastIndexOf('.'), src.length);
			var hsrc = src.replace(ftype, '_o'+ftype);

			aImages[i].setAttribute('hsrc', hsrc);
			
			aPreLoad[i] = new Image();
			aPreLoad[i].src = hsrc;
			
			aImages[i].onmouseover = function() {
				sTempSrc = this.getAttribute('src');
				this.setAttribute('src', this.getAttribute('hsrc'));
			}	
			
			aImages[i].onmouseout = function() {
				if (!sTempSrc) sTempSrc = this.getAttribute('src').replace('_o'+ftype, ftype);
				this.setAttribute('src', sTempSrc);
			}
		}
	}
}

window.onload = initRollovers;



//contentsØ‚è‘Ö‚¦

var current_obj;
var current_mc;
var obj_name = "cts-";

function show_cts(No,mc)
{
	if(current_obj)
	{
		current_obj.style.display = "none";
		current_mc.style.color = "#737373";
	}
	open_obj = document.getElementById(obj_name + No);
	if(open_obj)
	{
		mc.style.color = "#EF9B3C";
		open_obj.style.display = "block";
		current_obj = open_obj;
		current_mc = mc;
	}
}



//POPUP Window


function MM_openBrWindow(theURL,winName,features) { //v2.0
  window.open(theURL,winName,features);
}

window.name = "yamaha_web";

var special;

function swap_url(type)
{
	if(type == "top")
	{
		special =  window.open("r15/index.html", "special");
		window.blur();
		special.focus();
	}
	else
	{
		special =  window.open("../../r15/index.html", "special");
		window.blur();
		special.focus();
	}
}