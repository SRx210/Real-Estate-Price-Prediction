/* Reset and Base Styles */
* {
    margin: 0;
    padding: 0;
    box-sizing: border-box;
}

body {
    font-family: Arial, sans-serif;
    background-color: #f5f6fa;
    display: flex;
    flex-direction: column;
    align-items: center;
}

/* Background Image Banner */
.img {
    background: url('background.jpg') no-repeat center center;
    background-size: cover;
    width: 100%;
    height: 200px;
}

/* Form Container */
.form {
    background-color: #ffffff;
    padding: 30px;
    margin: 20px;
    border-radius: 10px;
    box-shadow: 0 4px 20px rgba(0, 0, 0, 0.1);
    width: 90%;
    max-width: 600px;
}

/* Headings */
h2 {
    color: #2f3640;
    font-size: 20px;
    margin-bottom: 10px;
}

/* Input Fields */
input[type="number"], select {
    width: 100%;
    padding: 10px;
    margin-bottom: 20px;
    font-size: 16px;
    border: 1px solid #dcdde1;
    border-radius: 5px;
}

/* Radio Button Field Group */
.switch-field {
    display: flex;
    gap: 15px;
    margin-bottom: 20px;
}

.switch-field input[type="radio"] {
    display: none;
}

.switch-field label {
    background-color: #f0f0f0;
    padding: 10px 15px;
    border-radius: 5px;
    cursor: pointer;
    font-size: 16px;
    transition: 0.3s ease;
    user-select: none;
}

.switch-field input[type="radio"]:checked + label {
    background-color: #0984e3;
    color: white;
}

/* Submit Button */
button.submit {
    background-color: #00b894;
    color: white;
    padding: 12px 20px;
    border: none;
    border-radius: 8px;
    cursor: pointer;
    font-size: 16px;
    transition: background-color 0.3s ease;
}

button.submit:hover {
    background-color: #019875;
}

/* Estimated Price Output */
.result h2 {
    margin-top: 20px;
    color: #2d3436;
    font-size: 22px;
    text-align: center;
}
