// javascript failus jāliek vienmēr html bodi taga beigās
// rekursija - funkcija kas atrod pati sevi 

// function checkParagraphContent() {
//     var element = document
//    .querySelector('#some-paragraph');
//   if (element.innerText == 'foo') {
//     element.innerText = 'bar';
//   } else {
//     element.innerText = 'foo';
//   }
// }

// function changeButtonName() {
//     var element = document
//    .querySelector('#crazyButton');
//   if (element.innerText == 'foo') {
//     element.innerText = 'bar';
//   } else if (element.innerText == 'bar') {
//     element.innerText = 'baz';
//   } else {
//     element.innerText = 'foo'
//   }
// }
  

// setInterval(buttonClick, 500);
// function checkParagraphContent() {
    
//     var elements = document.querySelectorAll('.other-paragraph');
//     for (var i = 0; i < elements.length; i++) {
//         var element = elements[i];
//         console.log(element);
//         var number = i + 1;
//         if (element.innerHTML == 'foo' + number ) {
//             element.innerHTML= 'bar' + number;
//           } else {
//             element.innerHTML = 'foo' + number ;
//           }
//     }
// }

// function add(number) {
//     var element = document
//         .getElementById('number');
//     var currentValue = parseInt(element.innerText);
//     element.innerText = currentValue + number;
// }

// var count = 0;
// function addCount(){
//     count++;
//     document    
//         .getElementById('counter')
//         .innerText = count;
// }




function isAnagram (str1, str2) {

    str1 = str1.replace(' ', '').split('').sort().join();
    str2 = str2.replace(' ', '').split('').sort().join();
    return str1 == str2;
}

function compareWords() {
   var firstWord = document.getElementById('firstWord');
   var secondWord = document.getElementById('secondWord');
        firstWord = firstWord.value;
        secondWord = secondWord.value;
   if (isAnagram(firstWord, secondWord)) {
       alert('the words are anagrams')
   } else { alert ('The words are NOT anagrams')}
   }





//     if (str1.length !== str2.length) {
//         return false;
//     }
    
//     var sortStr1 = str1.split('').sort().join('');
//     var sortStr2 = str2.split('').sort().join('');

//     return (sortStr1 === sortStr2);
// }

console.log('sula ' + isAnagram('sula', 'alus'));
console.log('aaa ' + isAnagram('aba', 'aba'));
console.log('a a b ' + isAnagram('a a b', 'a b a'));
console.log(isAnagram('dog','god')); // true
console.log(isAnagram('foo','bar')); // false
console.log(isAnagram('foo','fooo')); // false



