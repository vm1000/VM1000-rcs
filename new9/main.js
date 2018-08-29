// $('#btn1').click(function() {
//     $('.some-p').toggle(1000);
// });

// $('#btn2').click(function() {
//     $('#some-p2').toggle(1000);
// });

$ ('.i1').keyup(function() {
    if ($('#id1').val() == $('#id2').val()) {
        $('#p').html('yay!');
    } else {
        $('#p').html('oh no...');
    }
});