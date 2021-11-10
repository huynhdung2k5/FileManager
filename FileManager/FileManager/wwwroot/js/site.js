const btnDemo = document.querySelector('.js-btnDEMO');

$('#btnsidebar').on('click', function () {

    $('.js-slide').animate({
        width: "toggle"
    },100);
    //$('#sidebar').animate({
    //    'margin-left': '-250px'
    //},3000)
    
});

$('.js-img').on('click', ev => {
    ev.preventDefault();
    $('.js-img').toggleClass('css-border');
    $('.js-img').toggleClass('css-opacity');
    $('.css-btn').toggleClass('css-display');
});

$('.border-li>a').on('click',function() {

    if (this != $('.border-li>a.selected-bg.selected-border').get(0)) {
        $('.border-li>a.selected-bg.selected-border').removeClass('selected-bg selected-border');
    }
    $(this).toggleClass('selected-bg selected-border');
    //if (this != $('.border-li>a.selected-border')) {
    //    $('.border-li>a.selected-border').removeClass('selected-border');
    //}
    //$(this).toggleClass('selected-border');
})

