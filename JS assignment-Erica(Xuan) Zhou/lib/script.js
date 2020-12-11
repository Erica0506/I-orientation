// 1.	Write a JavaScript program to display the current day and time in the following format
// Sample Output : Today is : Friday. 
// Current time is : 4 PM : 50 : 22

function getDayAndTime() {
  var str1 = 'Today is : '
  var str2 = 'Current time is : '
  var d = new Date();
  var weekday = new Array(7);
  weekday[0] = "Sunday";
  weekday[1] = "Monday";
  weekday[2] = "Tuesday";
  weekday[3] = "Wednesday";
  weekday[4] = "Thursday";
  weekday[5] = "Friday";
  weekday[6] = "Saturday";

  function addZero(i) {
    if (i < 10) {
      i = "0" + i;
    }
    return i;
  }
  function addAMorPM(i){
    if (i>12){
      i = i - 12 +"PM";
    }else{
      i = i +"AM";
    }
    return i;  
  }

  var s = addZero(d.getSeconds());
  var m = addZero(d.getMinutes());
  var h = addAMorPM(d.getHours());

  var s1 = str1 + weekday[d.getDay()];
  var s2 = str2 + h + " : " + m + " : " + s;
  document.getElementById("demo1").innerHTML = s1 + '<br> ' + s2;
}

// 2.	Write a JavaScript program to get the current date.
// Expected Output : 
// mm-dd-yyyy, mm/dd/yyyy or dd-mm-yyyy, dd/mm/yyyy 

function getCurrentDate(){
var d = new Date();
var day = d.getDate()          // Get the day as a number (1-31)
var year = d.getFullYear()      // Get the four digit year (yyyy)
var month = d.getMonth() + 1       // Get the month (0-11)
var m = month + "-" + day + "-" + year + ", " + month + "/" + day + "/" + year 
document.getElementById("demo2").innerHTML = m;
}

// 3.	Write a JavaScript program to calculate multiplication and division of two numbers (input from user).


function Multiply(x, y){
var x = document.getElementById("1stNumber").value;
var y = document.getElementById("2stNumber").value;
var z = x*y;
document.getElementById("demo3").innerHTML = z;
}
function Divide(x, y){
var x = document.getElementById("1stNumber").value;
var y = document.getElementById("2stNumber").value;
var z = x/y;
document.getElementById("demo3").innerHTML = z;
}

// 4.	Write a JavaScript program to get the website URL (loading page)
function getURL(){
document.getElementById("demo4").innerHTML = 
"The full URL of this page is:<br>" + window.location.href;
}

// 5.	Write a JavaScript function that reverse a number 
// Example x = 32243;
// Expected Output : 34223

function ReverseNumber(){
var n = document.getElementById("NumberforReverse").value;
	n = n + "";
	rn = n.split("").reverse().join("");
  document.getElementById("demo5").innerHTML = rn;
}

// 6.	Write a JavaScript function which will take an array of numbers stored and find the second lowest and second greatest numbers, respectively. 
// Sample array : [1,2,3,4,5]
// Expected Output : 2,4 

function find22(){
  var inputArray = document.getElementById("inputArray").value;
  arr_num = inputArray.split(' ');
  arr_num.sort(function(a, b){return a - b});
  var uniqa = [arr_num[0]];
  var result = [];
  
  for(var j=1; j < arr_num.length; j++)
  {
    if(arr_num[j-1] !== arr_num[j])
    {
      uniqa.push(arr_num[j]);
    }
  }
  result.push(uniqa[1],uniqa[uniqa.length-2]);

  document.getElementById("demo6").innerHTML = result;
}

// 7.	Write a JavaScript program to get the integers in range (x, y). Go to the editor
// Example : range(2, 9)
// Expected Output : [3, 4, 5, 6, 7, 8]
function getInt()
{
  var range = function(start_num, end_num) 
  {
    if (end_num - start_num === 2) 
    {
      return [start_num + 1];
    } 
    else 
    {
      var list = range(start_num, end_num - 1);
      list.push(end_num - 1);
      return list;
    }
  };
  document.getElementById("demo7").innerHTML = range(2, 9);
}

// 8.	 Write a merge sort program in JavaScript.  
// Sample array : [34,7,23,32,5,62]
// Sample output : [5, 7, 23, 32, 34, 62]
function merge_sort(){
  var inputArray = document.getElementById("inArray").value;
  arr_num = inputArray.split(' ');
  arr_num.sort(function(a, b){return a - b});

  document.getElementById("demo8").innerHTML = arr_num;
}


// 9.	Write a JavaScript conditional statement to find the largest of five numbers. Display an alert box to show the result.  
// Sample numbers : -5, -2, -6, 0, -1 
// Output : 0 
function findlargest(){
  var inputArray = document.getElementById("Array9").value;
  arr_num = inputArray.split(' ');
  arr_num.sort(function(a, b){return a - b});
  var l = arr_num[arr_num.length-1];

  document.getElementById("demo9").innerHTML = l;
}



// 10.	Write a JavaScript function to validate whether a given value type is NaN or not.

function valueValidate(){
  function is_nan(val)
        {
        return val !== val;
        }
  document.getElementById("demo10").innerHTML = is_nan(NaN);//input values here
}

// 11.	Write a JavaScript function to check whether given value types are same or not.
function checkType(){
  function is_sameType(value1, value2) {
        if(is_nan(value1) || is_nan(value2)) {
         return is_nan(value1) === is_nan(value2);
        }
        return toString.call(value1) === toString.call(value2);
    }

  function is_nan(val)
        {
        return val !== val;
       } 
  document.getElementById("demo11").innerHTML = is_sameType(1, "cat");//input values here
}




