document.addEventListener("DOMContentLoaded", function () {
    const selectAllYesButton = document.querySelector('.btn.text-primary-hover.yes');
    const selectAllNoButton = document.querySelector('.btn.text-primary-hover.no');

    const radioButtons = document.querySelectorAll('input[type="radio"]');

    selectAllYesButton.addEventListener('click', function () {
        radioButtons.forEach(function (radioButton) {
            if (radioButton.value === "Yes") {
                radioButton.checked = true;
            } else {
                radioButton.checked = false;
            }
        });
    });

    selectAllNoButton.addEventListener('click', function () {
        radioButtons.forEach(function (radioButton) {
            if (radioButton.value === "No") {
                radioButton.checked = true;
            } else {
                radioButton.checked = false;
            }
        });
    });
});
