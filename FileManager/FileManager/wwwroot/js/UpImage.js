

$(function () {
	$('#btnUpload').click(function () {
		$('#fileUpload').trigger('click');
	});
	//su kien change upload
	$('#fileUpload').change(function () {
		if (window.FormData !== undefined) {
			var fileUpload = $('#fileUpload').get(0);
			var files = fileUpload.files;
			//tao obj formData
			var formData = new FormData();
			//dua vao form
			formData.append('file', files[0]);
			$.ajax({
				type: 'POST',
				url: '/Home/FileUpLoad',
				contentType: false,
				processData: false,
				data: formData,
				success: function (urlImage) {
					$('#picture').val(urlImage);
				},
				error: function (err) {
					alert('Loi!!!' + err.statusText);
				}
			});
		}
	});

	//hien thi list hinh anh
	$.ajax({
		type: 'GET',
		url: '/Home/GetAllFile',
		data: 'JSON',
		success: function (res) {
			res.files.forEach(function (val,index) {
				$('.js-content').append('<img class="js-img" height="180" width="200" src="' + val + '" />');
			});

			$(".js-img").click(function () {
				if (this != $('.js-img.css-border.css-opacity').get(0)) {
					$('.js-img.css-border.css-opacity').removeClass('css-border css-opacity');
					$('#btnNew.css-display').removeClass('css-display');
					$('#btnUpload.css-display').removeClass('css-display');
				}
				$(this).toggleClass('css-border css-opacity');
				$('#btnNew').toggleClass('css-display');
				$('#btnUpload').toggleClass('css-display');
				//hien thi button chuc nang của image
				if ($(this).hasClass('css-border css-opacity')) {
					$('.css-btn').removeClass('css-display');
				} else $('.css-btn').toggleClass('css-display');

			});
		}
	});


});