(function() {

	// This method is used to color alternating rows in a table when the
	// class "alternate-rows" is applied.
	function altRows(className) {
		var table = document.getElementsByClassName(className);

		for (i = 0; i < table.length; i++) {
			var rows = table[i].getElementsByTagName("tr"); 
			for (r = 0; r < rows.length; r++) {          
				if (r % 2 == 0) {
					rows[r].className = "evenrowcolor";
				} else {
					rows[r].className = "oddrowcolor";
				}      
			}
		}
	}

	window.onload=function() {
		altRows("alternate-rows")
    prettyPrint()
    var title = $('#page-title')
    if (title.length)
      title.html(document.title)

    var header = $('header[role=course-title]')
    if (header.length)
      header.html(document.title)
	}

   /////////////////////
   // IDE selection
   ////////////////////
    var $ideSelector = $('#ide-selector');

    $ideSelector.bind('recalc', function(e, newValue) {
        var value;

        if (newValue == undefined) {
             value = "xs";
        } else {
            value = newValue;
        }

        $(this).find('a').removeClass('active');
        $(this).find('a[data-name="' + value + '"]').addClass('active');

        $('#main ide, main .ide').hide();
        $('#main ide[name="' + value + '"], #main .ide.' + value).show();
    });

    if ($ideSelector.length > 0) {
        $ideSelector.trigger('recalc');
    }

    $ideSelector.on('click', 'a', function(e) {
        e.preventDefault();
        $ideSelector.trigger('recalc', $(this).attr('data-name'));
    });

})();

// This is used to show/hide code blocks
function toggleCode(btn, id) {
   var e = document.getElementById(id);
   if(e.style.display == 'block') {
      e.style.display = 'none';
      btn.innerHTML = "Show Code";
   }
   else {
      e.style.display = 'block';
      btn.innerHTML = "Hide Code";
   }
}

// This is used to show/hide text blocks
function toggleBlock(btn, id, showText, hideText) {
   var e = document.getElementById(id);
   if(e.style.display == 'block') {
      e.style.display = 'none';
      btn.innerHTML = showText;
   }
   else {
      e.style.display = 'block';
      btn.innerHTML = hideText;
   }
}

