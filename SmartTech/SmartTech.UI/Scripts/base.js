
function CallAjax(url, data) {
    ShowBlock();
    return  $.ajax({
        url: url,
        type: 'POST',
        contentType: 'application/json;charset=UTF-8',
        dataType: 'json',
        data: data,
        error: function (serverError) {
            CloseBlock();
            if (window.location.href.indexOf('/Default/Error') == -1) {
                window.location.href = '/Default/Error';
            }
        }
    });
}

function ShowBlock() {
    $.blockUI({
        css: {
            border: 'none',
            padding: '15px',
            backgroundColor: '#000',
            '-webkit-border-radius': '10px',
            '-moz-border-radius': '10px',
            opacity: 0.7,
            color: 'white'
        }
    });
}

function CloseBlock() {
    $.unblockUI();
}

