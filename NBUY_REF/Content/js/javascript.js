
$(document).ready(function () {
    $(window).scroll(function () {
        if ($(document).scrollTop() > 10) {
            $('#nav').addClass('shrink');
            $('#logo a').css('font-size', '25px');
        }
        else {
            $('#nav').removeClass('shrink');
            $('#logo a').css('font-size', '35px');
        }
    });
});