// Show/hide field when user chooses notification type
$('.js-notification-type input[type="radio"]').click(function () {
    $('.js-eventdate').addClass("d-none");
    $('.js-daysofweek').addClass("d-none");
    if (this.value == "HistoricEvent" || this.value == "OneTimeEvent") {
        $('.js-eventdate').removeClass("d-none");
    }
    else if (this.value == "PeriodicEvent") {
        $('.js-daysofweek').removeClass("d-none");
    }
});

ShowNotificationTypePropertiesAfterReloadPage();
function ShowNotificationTypePropertiesAfterReloadPage() {
    $.each($('.js-notification-type input[type="radio"]'), function (key, value) {
        if (value.checked) {
            this.click();
        }
    });
};