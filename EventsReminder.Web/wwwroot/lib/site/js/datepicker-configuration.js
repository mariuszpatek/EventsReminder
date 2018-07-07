// Changes for datatime picker - there was with validate date format
$(function () {
    $.validator.methods.date = function (value, element) {
        return this.optional(element) || moment(value, "DD.MM.YYYY", true).isValid();
    }
});

// Datepicker configuration
//$(function () {
//    $('.js-datepicker').datepicker({
//        format: 'dd.mm.yyyy',
//        weekStart: '1',
//        language: 'pl'
//    });
//});

$(function () {
    $('.js-datepicker').flatpickr({
        "dateFormat": "Y-m-d",
        "locale": "pl" 
    });

});
