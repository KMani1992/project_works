var target = "";


function jump(){

	var url = document.form1.select.options[document.form1.select.selectedIndex].value;

	if(url != "" ){

		if(target == 'top'){

			top.location.href = url;

		}
		else if(target == 'blank'){

			window.open(url, 'window_name');

		}
		else if(target != ""){

			eval('parent.' + target + '.location.href = url');

		}
		else{

			location.href = url;

		}

	}

}