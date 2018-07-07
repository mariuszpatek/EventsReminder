    // Change validation summary style to use boostrap classes
    $('form').submit(function () {
        $(function () {
            $('.validation-summary-errors').each(function () {
                $(this).addClass('alert');
                $(this).addClass('alert-danger');
            });

            $('.validation-summary-errors ul').each(function () {
                $(this).addClass('list-unstyled');
                $(this).addClass('m-0');
            });

        });
    });

    $(function () {
        $('.validation-summary-errors').each(function () {
            $(this).addClass('alert');
            $(this).addClass('alert-danger');
        });

        $('.validation-summary-errors ul').each(function () {
            $(this).addClass('list-unstyled');
            $(this).addClass('m-0');
        });

    });

    // Prevent multiple submitions
    $('.js-form-prevent-multiple-submitions').submit(function () {
        if ($(this).valid()) {
            $(this).find(':submit').attr('disabled', 'disabled');
        }
    });