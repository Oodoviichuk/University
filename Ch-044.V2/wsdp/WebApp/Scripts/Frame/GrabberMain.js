
let grabber = {
	current: 0,
	ListItems: JSON.parse($('#items').attr('data-list-items')),
	length: function () { return this.ListItems.length },
	getPathTo: function (element) {
		if (element.id !== '') {
			if (element.id == undefined) return "";
			return "//" + element.tagName.toLowerCase() + "[@id='" + element.id + "']";
		}

		if (element === document.body)
			return element.tagName.toLowerCase();

		let ix = 0;
		let siblings = element.parentNode.childNodes;
		for (var i = 0; i < siblings.length; i++) {
			var sibling = siblings[i];

			if (sibling === element) return getPathTo(element.parentNode) + '/' + element.tagName.toLowerCase() + '[' + (ix + 1) + ']';

			if (sibling.nodeType === 1 && sibling.tagName === element.tagName) {
				ix++;
			}
		}
	},
	InputSettings: function(){
		let inputs = $(".fields input:last");
		for (let i = 0; i < inputs.length; i++) {
			let inp = inputs[i];
			let name = inp.getAttribute("name");
			let pos = name.lastIndexOf("[");
			name = name.substring(0, pos);

			inp.setAttribute("name", name);
		}
	},
	CheckButtons: function () {
		if (this.current == this.length() - 1) {
			$('#Next').attr('disabled', true);
		}
		else {
			$('#Next').attr('disabled', false);
		}
		if (this.current == 0) {
			$('#Previous').attr('disabled', true);
		}
		else { $('#Previous').attr('disabled', false); }
	},
	NextAjax: function () {
		$.ajax({
			type: "POST",
			url: '../Next',
			data: ({ current: this.current }),
			success: function (data) {
				$('#iframe1').attr('src', data);
				$("#progress_bar").hide();
				this.CheckButtons();
				setTimeout(function () {
					this.EstablishingEvents();
				}, 10000);
			},
			error: function () {
				alert('Error occured');
				$("#progress_bar").hide();
			}
		});
	},
	PreviousAjax: function () {
		$.ajax({
			type: "POST",
			url: '../Previous',
			data: ({ current: this.current }),
			success: function (data) {
				$('#iframe1').attr('src', data);
				$("#progress_bar").addClass("hidden");
				this.CheckButtons();
				setTimeout(function () {
					this.EstablishingEvents();
				}, 10000);
			},
			error: function () {
				alert('Error occured');
				$("#progress_bar").addClass("hidden");
			}
		});

	},
	EstablishingEvents: function () {
		let iframe = document.getElementById("iframe1");
		iframe = iframe.contentWindow.document;

		$(iframe)
		.mouseout(function (event) {
			event.target.style.border = "";
		})
		.mouseover(function (event) {
			if (event.shiftKey) {
				event.target.style.border = "2px red solid";
				$("#clicked").val(getPathTo(event.target));
			}
		}
	);
		$('input').click(function (event) {
			//delete all Id`s
			$('#clicked').attr('id', null);

			//Add new id
			$(this).attr('id', 'clicked');
		});

		$(".list-inline-item:nth-child(3)").addClass("active");

		$('#Next').unbind().click(function () {
			if (this.current != this.length() - 1) {
				this.current++;
			};
			$("#progress_bar").removeClass("hidden");
			this.NextAjax();

			this.CheckButtons();
			setTimeout(function () {
				EstablishingEvents();
				$(".text-danger").html("");
				console.log("EV");
			}, 10000);

		});

		$('#Previous').unbind().click(function () {
			if (this.current != 0) {
				this.current--;
			};
			this.PreviousAjax();
			this.CheckButtons();
			setTimeout(function () {
				EstablishingEvents();
				console.log("EV");
			}, 10000);

		});
	},
	GetAllXpath: function () {
		let inputs = $(".inputfield");
		inputs.each(function () {
			let url = this.ListItems[this.current];
			let xpath = $(this).val();
			this.PrewiewAjax($(this), url, xpath);
		});
	},
	PrewiewAjax: function (input, url, xpath) {
		$.ajax({
			type: "POST",
			url: '../GetPreview',
			data: ({ url: url, xpath: xpath }),
			success: function (data) {
				input.siblings("b").html(data);
			},
			error: function () {
				alert('Error occured');
			}
		});
	},
	AddField: function (btn) {
		let name = $(btn).closest(".form-group").find('input:last').attr('name');

		let input = document.createElement("input");
		input.setAttribute("class", "form-control inputfield");
		input.setAttribute("placeholder", "Click here and get Xpath");
		input.setAttribute("style", "margin-top:10px;");
		input.setAttribute("name", name);
		input.setAttribute("required", "required");

		$(btn).closest(".form-group").children(".fields").append(input);

		let br = document.createElement("br");
		let b = document.createElement("b");

		$(btn).closest(".form-group").children(".fields").append(br);
		$(btn).closest(".form-group").children(".fields").append(b);
		this.EstablishingEvents();
	}
}


$(document).ready(function () {
	grabber.InputSettings();
	$(".body-content").removeClass("container");
	$(".body-content").addClass("container-fluid");
	
	grabber.CheckButtons();
	setTimeout(function () {
		grabber.EstablishingEvents();
	}, 10000);

});


