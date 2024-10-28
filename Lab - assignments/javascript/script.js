// ASSIGNMENT 1
// Write a JavaScript program that takes two numbers as input from the user and
// displays their sum.

const Add = () => {
  let num1 = Number(document.getElementById("num1").value);
  let num2 = Number(document.getElementById("num2").value);
  result = num1 + num2;
  document.getElementById("result1").innerHTML = `${num1} + ${num2} = ${
    num1 + num2
  }`;
};

// ASSIGNMENT 2
// Create a JavaScript program that takes a number as input from the user and determines
// whether the number is even or odd.
const EvenOdd = () => {
  let num = Number(document.getElementById("num3").value);
  if (num % 2 == 0) {
    document.getElementById("result2").innerHTML = "The number is even";
  } else if (num % 2 == 1) {
    document.getElementById("result2").innerHTML = "The number is odd";
  } else {
    document.getElementById("result2").innerHTML = "Error";
  }
};

// ASSIGNMENT 3
// Write a JavaScript function that takes three numbers as input from the user and
// displays the largest number.
const largestNumber = () => {
  let a = Number(document.getElementById("a").value);
  let b = Number(document.getElementById("b").value);
  let c = Number(document.getElementById("c").value);

  let largest = Math.max(a, b, c);
  document.getElementById(
    "result3"
  ).innerHTML = `${largest} is the largest number`;
  //   if (a > b && a > c) {
  //     document.getElementById("result3").innerHTML = `${a} is the largest number`;
  //   } else if (b > a && b > c) {
  //     document.getElementById("result3").innerHTML = `${b} is the largest number`;
  //   } else if (c > a && c > b) {
  //     document.getElementById("result3").innerHTML = `${c} is the largest number`;
  //   } else {
  //     document.getElementById("result3").innerHTML = "Enter unique numbers";
  //   }
};

// ASSIGNMENT 4
// Create a basic to-do list using JavaScript. The user should be able to add tasks, and the
// tasks should be displayed below the input.
const todolist = [];
const addTodo = () => {
  todolist.push(document.getElementById("todo").value);
  document.getElementById("todo").value = null;
};

const showTodos = () => {
  document.getElementById("result4").innerHTML = "";
  const todos = todolist.map((item, index) => {
    const li = document.createElement("li");
    li.textContent = `${index}: ${item}`;
    return li;
  });
  const createTodoList = (li) => {
    document.getElementById("result4").appendChild(li);
  };
  todos.forEach(createTodoList);
};

// ASSIGNMENT 5
// Create a temperature converter that converts a given temperature from Celsius to
// Fahrenheit using JavaScript.
const tempConvert = () => {
  let celsius = document.getElementById("temperature").value;
  let fahrenheit = (celsius * 9) / 5 + 32;
  document.getElementById(
    "result5"
  ).innerHTML = `${celsius} converted to fahrenheit = ${fahrenheit}`;
};

// ASSIGNMENT 6
// Write a simple countdown timer using JavaScript. The user should input the number
// of seconds, and the timer should count down and display the time remaining.
const startCountDown = () => {
  let inputTime = 0;
  inputTime = Number(document.getElementById("time").value);
  document.getElementById(
    "time-remaining"
  ).innerHTML = `Remaining time : ${inputTime}`;
  //intervel
  count = setInterval(() => {
    inputTime -= 1;
    if (inputTime > 0) {
      document.getElementById(
        "time-remaining"
      ).innerHTML = `Remaining time : ${inputTime}`;
    } else if (inputTime <= 0) {
      document.getElementById("time-remaining").innerHTML = "Time Up";
    }
  }, 1000);
};

// ASSIGNMENT 7
// Create a webpage where the user can change the background color of the page by
// selecting a color from an input field.
const changeColor = (event) => {
  document.getElementById("html-body").style.backgroundColor =
    event.target.value;
};
document.getElementById("color-picker").addEventListener("input", changeColor);

// ASSIGNMENT 8
// Build a simple calculator with HTML and JavaScript that can perform basic
// operations such as addition, subtraction, multiplication, and division.
const calculatorFunc = () => {
  let firstNum = Number(document.getElementById("calc1").value);
  let secondNum = Number(document.getElementById("calc2").value);
  let operation = document.getElementById("operation").value;
  switch (operation) {
    case "+":
      document.getElementById(
        "result8"
      ).innerHTML = `${firstNum} + ${secondNum} = ${firstNum + secondNum}`;
      break;
    case "-":
      document.getElementById(
        "result8"
      ).innerHTML = `${firstNum} - ${secondNum} = ${firstNum - secondNum}`;
      break;
    case "*":
      document.getElementById(
        "result8"
      ).innerHTML = `${firstNum} * ${secondNum} = ${firstNum * secondNum}`;
      break;
    case "/":
      if (secondNum == 0) {
        document.getElementById("result8").innerHTML =
          "Division by 0 not possible";
      } else {
        document.getElementById(
          "result8"
        ).innerHTML = `${firstNum} / ${secondNum} = ${firstNum / secondNum}`;
      }
      break;
    default:
      document.getElementById("result8").innerHTML = "invalid operation";
  }
};

// ASSIGNMENT 9
// Create a simple digital clock that displays the current time and updates every second.
const digitalClock = () => {
  const updateTime = setInterval(() => {
    const date = new Date();
    let hours = date.getHours();
    let minutes = date.getMinutes();
    let seconds = date.getSeconds();
    let am = false;
    console.log(hours, minutes, seconds);
    if (hours >= 12) {
      hours = hours - 12;
    } else if (hours < 12) {
      am = true;
    }
    document.getElementById("time-now").innerHTML = `${hours}
    : ${minutes} : ${seconds} ${am ? "AM" : "PM"}`;
  }, 1000);
};

// ASSIGNMENT 10
// Create a tip calculator that allows users to input the bill amount and select a tip
// percentage. The app should calculate the total bill amount, including the tip.
const tipCalculator = () => {
  let billAmount = Number(document.getElementById("bill-amount").value);
  let tipPercent = Number(document.getElementById("tip-percent").value);
  let totalAmount = billAmount + (billAmount * tipPercent) / 100;
  document.getElementById(
    "result10"
  ).innerHTML = `Your total bill is ${totalAmount}`;
  console.log(totalAmount);
};

// ASSIGNMENT 12
// Build a simple stopwatch that starts counting from 00:00 when the user clicks the
// "Start" button and stops when they click the "Stop" button. The user can also reset the time back
// to 00:00 by clicking "Reset."
let running = false;
let timeUpdate;
const stopWatch = () => {
  if (running) {
    running = false;
  } else {
    running = true;
  }
  console.log(running);
  if (running) {
    document.getElementById("stopwatch-button").innerHTML = "Stop";
    let minute = 0;
    let second = 0;
    document.getElementById("stopwatch").innerHTML = "00 : 00";
    timeUpdate = setInterval(() => {
      second += 1;
      if (second == 60) {
        second = 0;
        minute += 1;
      }
      document.getElementById("stopwatch").innerHTML = `${
        minute >= 10 ? minute : "0" + minute
      } : ${second >= 10 ? second : "0" + second}`;
      console.log(second);
    }, 1000);
  } else {
    clearInterval(timeUpdate);
  }
};

const stopWatchReset = () => {
  running = false;
  clearInterval(timeUpdate);
  document.getElementById("stopwatch").innerHTML = "00 : 00";
  document.getElementById("stopwatch-button").innerHTML = "Start";
};

// ASSIGNMENT 13
// Build a simple web page that allows the user to toggle between light and dark modes.
// The page should switch between light and dark backgrounds and corresponding text colors when
// the user clicks a "Toggle Mode" button.
darkMode = false;
const toggleMode = () => {
  if (darkMode) {
    darkMode = false;
  } else {
    darkMode = true;
  }
  if (darkMode) {
    document.body.style.backgroundColor = "#3A3A3A";
    document.querySelectorAll("h2").forEach((h2) => {
      h2.style.color = "white";
    });
    document.querySelectorAll("p").forEach((p) => {
      p.style.color = "white";
    });
  } else {
    document.body.style.backgroundColor = "antiquewhite";
    document.querySelectorAll("h2").forEach((h2) => {
      h2.style.color = "black";
    });
    document.querySelectorAll("p").forEach((p) => {
      p.style.color = "black";
    });
  }
};

// ASSIGNMENT 14
// Create a random quote generator that displays a random quote from an array of
// quotes each time a button is clicked.
const quotes = [
  "Success is not final, failure is not fatal: It is the courage to continue that counts. — Winston Churchill",
  "What you get by achieving your goals is not as important as what you become by achieving your goals. — Zig Ziglar",
  "Your time is limited, so don’t waste it living someone else’s life. — Steve Jobs",
  "In the middle of every difficulty lies opportunity. — Albert Einstein",
  "Believe you can and you're halfway there. — Theodore Roosevelt",
  "Do something today that your future self will thank you for.",
  "Happiness is not something ready-made. It comes from your own actions. — Dalai Lama",
  "Small steps in the right direction can turn out to be the biggest step of your life.",
];
const generateQuote = () => {
  let x = Math.floor(Math.random() * 7);
  document.getElementById("quote").innerHTML = quotes[x];
  console.log(quotes[x]);
};

// ASSIGNMENT 15
