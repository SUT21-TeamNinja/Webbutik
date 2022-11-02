
$('#trapezoid').mouseleave(function () {
    $('#trapezoid').css({
        'margin-top': '-175px'
    });
    $('.sub-home').css({
        'display': 'none'
    });
    $('.sub-login').css({
        'display': 'none'
    });
}).mouseenter(function () {
    $('#trapezoid').css({
        'margin-top': '-40px'
    });
});

