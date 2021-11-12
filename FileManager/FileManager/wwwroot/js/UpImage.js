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
					$('#pictureUpload').attr('src', urlImage);
					$('#picture').val(urlImage);
				},
				error: function (err) {
					alert('Loi!!!' + err.statusText);
				}
			});
		}
	});
});