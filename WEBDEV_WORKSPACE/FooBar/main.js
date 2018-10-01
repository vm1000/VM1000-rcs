// function goodButton() {
//     var element = document
//     .querySelector('#crazyButton');
//     if (element.innerText == 'Foo') {
//         element.innerText = 'Bar';
//     } else if (element.innerText == 'Bar') {
//         element.innerText = 'Baz';
//     } else element.innerText = 'Foo';
// }

// function niceButton() {
//    var elements = document.querySelectorAll('.some-paragraph');
//     for (var i = 0; i < elements.length; i ++) {
//        var element = elements[i];
//        console.log(element);
//        var number = i + 1;
// if(element.innerHTML == 'Foo' + number) {
//     element.innerHTML = 'Bar' + number;
//     } else
//     element.innerHTML = 'Foo' + number;
//     }
// }





function add(number) {
    element = document
    .getElementById('input');
    var currentValue = parseInt(element.value);
   element.value = currentValue + number;
}

