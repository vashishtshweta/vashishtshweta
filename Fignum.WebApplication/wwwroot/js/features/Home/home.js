$(document).on('keydown', '.js-passedInValue', clearPrimeNumber);

function clearPrimeNumber(e) {
    $('.js-primeNumber').hide();
    $('#PrimeNumber').val(null)
}


