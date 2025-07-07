// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

$(document).ready(function () {
    jQueryModalGet = (url, title) => {
        try {
            $.ajax({
                type: 'GET',
                url: url,
                contentType: false,
                processData: false,
                success: function (res) {
                    $('#form-modal .modal-body').empty()
                    $('#form-modal .modal-body').append(res);
                    $('#form-modal .modal-title').html(title);
                    $('#form-modal').modal('show');
                },
                error: function (err) {
                    console.log(err)
                }
            })
            return false;
        } catch (ex) {
            console.log(ex)
        }
    }
    jQueryModalPost = form => {
        try {
            $.ajax({
                type: 'POST',
                url: '/edit-resume?handler=ExperienceCreateOrEdit',
                headers: {
                    RequestVerificationToken: 
                        $('input:hidden[name="__RequestVerificationToken"]').val()
                },
                data: new FormData(form),
                contentType: false,
                processData: false,
                success: function () {
                    if (res.isValid) {
                        $('#employmentHistory').empty();
                        $('#employmentHistory').append(res);
                        $('#form-modal').modal('hide');
                    }
                },
                error: function (err) {
                    console.log(err)
                },
                failure: function (response) {
                    alert(response);
                }
            })
            return false;
        } catch (ex) {
            console.log(ex)
        }
    }
    jQueryModalDelete = form => {
            try {
                $.ajax({
                    type: 'POST',
                    url: form.action,
                    data: new FormData(form),
                    contentType: false,
                    processData: false,
                    success: function (res) {
                        $('#viewAll').html(res.html);
                    },
                    error: function (err) {
                        console.log(err)
                    }
                })
            } catch (ex) {
                console.log(ex)
            }
        
    }
});
