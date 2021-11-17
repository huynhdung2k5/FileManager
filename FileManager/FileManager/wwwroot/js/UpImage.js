

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

				}
				$(this).toggleClass('css-opacity css-border');

				if ($('.css-btn').get(0) != $('.css-btn.css-display').get(0)) {
					$('.css-btn.css-display').removeClass('css-display');
				}
				$('.css-btn').toggleClass('css-display');

			});
		}
	});


});