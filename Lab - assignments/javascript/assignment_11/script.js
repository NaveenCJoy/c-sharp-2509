const submitAns = () => {
  let score = 0;
  const answers = document.querySelectorAll('input[type="radio"]:checked');
  console.log(answers);

  //   answers.forEach((answer) => {
  //     if (answer.value == "correct") {
  //       score += 1;
  //     }
  //   });

  let correctAnswers = [];
  let wrongAnswers = [];
  let i = 0;
  answers.forEach((answer) => {
    i += 1;
    if (answer.name == i && answer.value == "correct") {
      correctAnswers.push(i);
      score += 1;
    } else if (answer.name == i && answer.value == "wrong") {
      wrongAnswers.push(i);
    }
  });

  console.log(correctAnswers);

  document.getElementById(
    "result"
  ).innerHTML = `You got ${score} / 4 answers correct`;
  console.log(score);

  document.getElementById(
    "correct-answers"
  ).textContent = `You got these questions right: ${
    correctAnswers.length > 0 ? correctAnswers : "nil"
  }`;

  document.getElementById(
    "wrong-answers"
  ).textContent = `You got these questions wrong: ${
    wrongAnswers.length > 0 ? wrongAnswers : "nil"
  }`;

  correctAnswers.forEach((q) => {});
};
