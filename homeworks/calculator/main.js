var numbers = document.querySelectorAll('.number');
// console.log(numbers);
var operations = document.querySelectorAll('.operator')
// console.log(operations);
var decimalBtn = document.getElementById('decimal')
// console.log(decimal);
var deleteAllBtn = document.getElementById('delete')
// console.log(deleteAll);
var resultBtn = document.getElementById('eqn-bg')
// console.log(result);
var display = document.getElementById('display')
// console.log(screen);
var memoryCurrentNumber = 0
var memoryNewNumber = false
var memoryPendingOperation = ''
var localOperationMemory

for (var i=0; i<numbers.length; i++) {
    var number = numbers[i];
    number.addEventListener('click', function (e){
        numberPress(e.target.textContent);
    });
};
 

for (var i=0; i<operations.length; i++) {
    var operationBtn = operations[i];
    operationBtn.addEventListener('click', function (e){
        operation(e.target.textContent); 
});
};

 
decimalBtn.addEventListener('click', decimal);

deleteAllBtn.addEventListener('click', deleteAll);

resultBtn.addEventListener('click', result);



function numberPress(number) {
    if(memoryNewNumber) {
        display.value = number;
        memoryNewNumber = false;
    } else {
        if(display.value === '0') {
            display.value = number;
        } else {
            display.value +=number;
        }
    }
  
    console.log('the number '+ number + ' button is clicked');
};


function operation(op) {
   var localOperationMemory = display.value;

    if(memoryNewNumber && memoryPendingOperation !== '=') {
        display.value = memoryCurrentNumber;
    } else {
        memoryNewNumber = true;
        if (memoryPendingOperation === '+') {
            memoryCurrentNumber += parseFloat(localOperationMemory);
        } else if (memoryPendingOperation === '-') {
            memoryCurrentNumber -= parseFloat(localOperationMemory);
        } else if (memoryPendingOperation === '*') {
            memoryCurrentNumber *= parseFloat(localOperationMemory);
        } else if (memoryPendingOperation === '/') {
            memoryCurrentNumber /= parseFloat(localOperationMemory);
        } else {
            memoryCurrentNumber = parseFloat(localOperationMemory);
        }
        display.value = memoryCurrentNumber;
        memoryPendingOperation = op;
    } 
    console.log('the ' + op + ' operation button is clicked');
};

function deleteAll(id) {
        (id === 'delete') 
        display.value = '0'
        memoryNewNumber = true;
        memoryCurrentNumber = 0;
        memoryPendingOperation = '';
    
    console.log('the delete button is clicked');
};

function decimal() {
    var localDecimalMemory = display.value;

    if (memoryNewNumber) {
        localDecimalMemory = '0.';
        memoryNewNumber = false;
    } else {
        if (localDecimalMemory.indexOf('.') === -1 ) {
        localDecimalMemory += '.'
        }
    }
    display.value = localDecimalMemory;
    console.log('the decimal button is clicked');
};

function result() {
    console.log('the result button is clicked');
};