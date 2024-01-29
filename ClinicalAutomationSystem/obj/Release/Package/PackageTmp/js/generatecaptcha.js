
function generateCaptcha() {
    var num1 = Math.floor(Math.random() * 10);
    var num2 = Math.floor(Math.random() * 10);
    var operation = ['+', '-', '*', '/'][Math.floor(Math.random() * 4)];
    var result = 0;

    switch (operation) {
        case '+':
            result = num1 + num2;
            break;
        case '-':
            result = num1 - num2;
            break;
        case '*':
            result = num1 * num2;
            break;
        case '/':
            // Avoid division by zero
            if (num2 === 0) {
                num2 = 1;
            }
            result = num1 / num2;
            break;
    }

    document.getElementById("captcha-question").innerHTML = num1 + " " + operation + " " + num2 + " = ?";
    document.getElementById("captcha-result").value = result;
}

// Function to validate the CAPTCHA
function validateCaptcha() {
    var userAnswer = parseInt(document.getElementById("user-captcha").value);
    var correctAnswer = parseInt(document.getElementById("captcha-result").value);

    if (userAnswer === correctAnswer) {
        alert("CAPTCHA Verification Successful. You can now proceed.");
    } else {
        alert("CAPTCHA Verification Failed. Please try again.");
        generateCaptcha();
    }
}
