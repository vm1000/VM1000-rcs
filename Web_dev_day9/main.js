// document.getElementById('some-btn')
// .addEventListener('click', changeParagraphText);

// function changeParagraphText() {
//     var el = document.getElementById('super-p');
//     if (el.innerText == 'Foo') {
//         el.innerText = 'Bar';
//     } else {
//         el.innerText = 'Foo';
//     }
// }



// document.getElementById('some-btn')
// .addEventListener('click', function() {
//     var el = document.getElementById('super-p');
//     if (el.innerText == 'Foo') {
//         el.innerText = 'Bar';
//     } else {
//         el.innerText = 'Foo';
//     }
// });


// $('#some-btn')    tas pats jQuery
// jQuery('#some-btn').click(function() {
//     $('.super-p').each(function(){
//         var num = $(this).attr('data-number');
//          if ($(this).html() == 'foo ' + num) {
//     $(this).html('bar ' + num);
//    } else if 
//    ($(this).html() == 'bar ' + num) {
//     $(this).html('baz ' + num);
//    } else 
//        $(this).html('foo ' + num);
//     })
//    if ($('.super-p').html() == 'foo') {
//     $('.super-p').html('bar');
//    } else if 
//    ($('.super-p').html() == 'bar') {
//     $('.super-p').html('baz');
//    } else 
//        $('.super-p').html('foo');

// });



$('#some-btn').click(function () {
    if ($('.super-p span').html()
        == 'foo ') {
        $('.super-p span').html
            ('bar ');
    } else if
    ($('.super-p span').html() == 'bar ') {
        $('.super-p span').html('baz ');
    } else {
        $('.super-p span').html('foo ');
    }

});
//  nepabeigts!!!

$('#some-other-btn').click(function () {
    $('.super-p').toggle(1000);
});

$('.add').click(function () {
    var action = $(this).attr('data-action');
    var currentNumber = $('#some-input').val();
    var newValue = parseInt(currentNumber) + parseInt(action);
    $('#some-input').val(newValue);

})
