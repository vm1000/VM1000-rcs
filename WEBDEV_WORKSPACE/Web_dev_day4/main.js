var someNumber = 123; // integer
var someDecimal = 3.14; // float
var someString = 'Hello world'; //string
var someTrue = true; // boolean, jeb bool
var someNothing = null; //mainīgais bez vērtības

var someArray = ['vaz',
    'zaz',
    'gaz',
    'maz',
    'bmw',
    1,
    3.14,
    true,
]; //array, massīvs ar vairākām vērtībām/mainīgiem
// var i = 1;
//console.log(someArray[i]);

var johnny = {
    name: 'Johnny',
    surename: 'Doe',
    fullName: 'Johnny Doe',
    age: '21',
}; //object
//console.log(johnny);

// var i = 'foo';
// console.log(i);
// i = 'bar';
// console.log(i);
// i = 'has';
// console.log(i);
// i = 1;
// console.log(i);
// i = 2;
// console.log(i);
// i = 3;
// console.log(i);


// +
// - 
// *
// /
// %
// var number1 = 2;
// var number2 = 4;
// console.log(1 + 1);
// console.log(2 + 2 * 2);
// console.log(number1 + number2);
// console.log(number1 + 3);
// var number3 = number1 - number2;
// console.log(number3);
// console.log((2 + 2) * 2);
// number1 = number1 + 1; 
// number += 1; //palielina mainīgo par viens
// number1 ++;  //palielina mainīgo par viens
// number1 --;  //pazemina mainīgo par viens

// console.log(4 % 2); //paņem skaitni, izdala un parāda atlikumu, jeb sanāk 0

// console.log('foo' + 'bar');
// console.log('1' + 1);
// console.log(1 + '1');

// == ir vienāds
// != nav vienāds
// >
// <
// >=
// <=
// ===   strict comparisson (eaqual)
// !==    strict comparisson (not eaqual)

//jebkurš skaitlis ir true, izņemot nulle
// strict comparisson salīdzina gan mainīgā vērtību gan arī mainīgā tipu

// if (i == '1') {
//     console.log('was true');
// } else {
//     console.log('was not true');
// }


// anna-->Čau, Anna, Jānis-->whatsapp Jānis, kkas cits--> nepazīstu tevi
//
//  var name = 'Ann';

// if (name == 'Anna') {
//     console.log('Čau, Anna');
// } else {
//     if (name == 'Jānis')  {
//         console.log('Whatsapp, Jānis'); 
//     } else { console.log('nepazīstu tevi');
//     }
// }    

// kvadrātiekavas ir domātas masīviem, figūriekavas ir objektiem un kunkfijām/blokiem, parastās iekavas ir pārējam

// var a = 1;
// var b = 2;
// var c = 3;
// // && nozīmē UN
// // || VAI apgalvojums
// if (a == 2 && (b == 3 || c == 3)) {

// }

// var name = 'Jānis';

// // Jānis, Kārlis, Zane -> čau, zināmais cilvēk, else -> nepazīstu tevi
// if (name == 'Jānis' 
// || name =='Kārlis'
// || 
// name == 'Zane') 
// {
//     console.log('čau,zināmais cilvēk');
// } else {
//     console.log('Nepazīstu tevi');
// }

// switch (name) {
//     case 'Jānis':
//     console.log('čau, zināmais cilvēk');
//     break;
//     case 'Kārlis':
//     console.log('čau, zināmais cilvēk');
//     break;
//     case 'Zane':
//     console.log('čau, zināmais cilvēk');
//     break;
//     default:
//     console.log('Nepazīstu tevi');
// }

// var i = 0;
// while (i<10) {
//     if (i < 5){
//         console.log(i);
//     }
//     i ++;
// }
// console.log(i);

// lai apturētu kkādu komandu, kas uzkārusies jāuzpie control+c

//izskaita līdz 20 un izdrukā pāra ciparu
// izskaita no 20 līdz 0

// var i = 0;
// while (i <= 20) {
//     i += 2;
//     console.log(i);
// }

// var i = 0;
// while (i <= 20) {
//     if (i%2==0){
//     console.log(i);
// }
// i ++;
// }

// var a = 20;
// while (a > 0) {
//     // a -= 1;           izdrukā pirms ir apdeitots
//     console.log(a);
//     // a -= 1;           izdrukās pēc apdeitošanas
// }


// var i = 0;
// while (i<20) {
//     i++;
//     if(i == 5){
//         continue;
//     }
//     console.log(i);
// }
// console.log(i);

// cikli angliski saucās "loop"

//while ciklā nosacījums tiek pārbaudīts paša sākumā, bet do-while ciklā nosacijums izpildās beigās


// var i = 20;
// do {
//     console.log(i);
//     i ++;
// } while(i<20);


// for (var i = 0; i < 20; i++) {
//     console.log(i);
// }


// for (var i = 20; i > 0; i -=1) {
//     console.log(i);
// }


// var cars = ['vas', 'gaz','zaz','maz','uaz','bmw'];
// for (var index = 0; index < cars.length; index++) {
//     var car = cars[index];
//     console.log(car);
// }

//izvadīt vienu
//ozvadīt visus izņemot vienu

// var cars = ['vas', 'gaz','zaz','maz','uaz','bmw'];
// var superCar = 'gaz';
// for (var index = 0; index < cars.length; index++) {
//     var car = cars[index];
//     if (index == superCar) {
//     console.log(car);
//     }
// }




//funkcijas
// function addTwoNumbers(number1, number2) {
//     return number1 + number2;
// }
// console.log(addTwoNumbers(2, 3));


//funkcija kas paņem 2 parametrus -> cilvēka vārds un vecums, un izdrukā textu Kārlis, 50 "čau, kārli, tev ir 50 gadi"

// function person (name, age) {
//     console.log('čau ' + name + ' tev ir ' + age + ' gadi');
// }
// person('kārlis', 30);

// Fizz Bazz
// Uzrakstīt programmu, kas izskaita no 0 līdz 30.
// Ja skaitlis dalās bez atlikuma ar 2 (ir pāra skaitlis), tad izdrukā vārdu "Fizz"
// Ja skaitlis dalās bez atlikuma ar 3, tad izvada "Bazz"
// Ja bez atlikuma dalās ar abiem, tad izvada "Fizz Bazz"
// Ja nedalās bez atlikuma ar nevienu, tad izvada skaitli


// var i = 0;
// while (i <= 30) {
//     if (i % 2 == 0 && i % 3 == 0) {
//         console.log ('Fizz Bazz')
//     }
//     else {
//         if (i % 2 == 0 ) {
//             console.log ('Fizz')
//         }
//         else {
//             if (i % 3 == 0) {
//                 console.log('Bazz')
//             }
//             else {
//             console.log(i);}
//         }
//     }
//     i ++;
// }


// for(var i = 0; i <= 30; i ++) {
//     var output = '';
//     if (i % 2 == 0) {
//         output = 'Fizz ';
//     }
//     if (i % 3 == 0) {
//         output += 'Bazz';
//     }
//     if (output === '') {
//         output = i;
//     }
//     console.log(output);
// }