$(document).ready(function () {

    const urlParams = new URLSearchParams(window.location.search);

    if (urlParams.get('isSuccess') == "True") {

        const url = new URL(window.location.href);
        url.searchParams.set('isSuccess', 'false');
        var counter = 5;
        setInterval(function () {
            counter--;
            if (counter >= 0) {
                span = document.getElementById("count");
                span.innerHTML = counter;
            }
            // Display 'counter' wherever you want to display it.
            if (counter === 0) {
                //    alert('this is where it happens');
                clearInterval(counter);
                window.location.href = window.location.origin;
            }
        }, 1000);
    }

    form.addEventListener('submit', function () {

        // Disable the submit button
        submitButton.setAttribute('disabled', 'disabled');

        // Change the "Submit" text
        submitButton.value = 'Please wait...';

    }, false);

});