//var deleteFolderUrl = '';
//var windowWidth = $(window).width();
var AjaxManager = {

    SendJson: function (serviceUrl, jsonParams, successCalback, errorCallback) {

        $.ajax({
            cache: false,
            async: true,
            type: "POST",
            url: serviceUrl,
            data: jsonParams,
            success: successCalback,
            error: errorCallback
        });

    },

    SendJsonAsyncON: function (serviceUrl, jsonParams, successCalback, errorCallback) {

        $.ajax({
            cache: false,
            async: false,
            type: "GET",
            url: serviceUrl,
            data: jsonParams,
            success: successCalback,
            error: errorCallback
        });

    },

    populateCombo: function (container, data, defaultText) {
        var cbmOptions = "<option value=\"0\">" + defaultText + "</option>";
        $.each(data, function () {
            cbmOptions += '<option value=\"' + this.Id + '\">' + this.Name + '</option>';
        });

        $('#' + container).html(cbmOptions);

    },
}