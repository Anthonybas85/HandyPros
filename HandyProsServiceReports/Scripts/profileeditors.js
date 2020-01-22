$(document).ready(function () {

    BuildFCKEditor();
    BuildFCKEditorFR();
    //    $("#SendMail").click(function () {
    //        var bod = FCKeditorAPI.GetInstance('BodyEditor').GetHTML();
    //        $('#Body').val(bod);
    //        //        return true;
    //        $(this).parents('form:first').submit();
    ////        return false;
    //    });

    $("#SendMail").click(function () {

        var bod = FCKeditorAPI.GetInstance('BodyEditor').GetHTML();
        $('#Body').val(bod);


        //        var sub = $('#Subject').val();
        //        //var temp = $('#Template option:selected').val();
        //        var url = '/tool/sendemails';
        //        $.post(url,
        //            {
        //                Subject: sub,
        //                Body: bod
        //            },
        //            function (resp) { alert(resp); }
        //            , 'html');

    });

    $("#Submit").click(function () {

        var bod = FCKeditorAPI.GetInstance('BodyEditor').GetHTML();
        $('#Body').val(bod);


        //        var sub = $('#Subject').val();
        //        //var temp = $('#Template option:selected').val();
        //        var url = '/tool/sendemails';
        //        $.post(url,
        //            {
        //                Subject: sub,
        //                Body: bod
        //            },
        //            function (resp) { alert(resp); }
        //            , 'html');

    });
    //    $("#PreviewEmail").click(function () {

    //        var bod = FCKeditorAPI.GetInstance('BodyEditor').GetHTML();
    //        $('#Body').val(bod);
    //        var url = '/tool/sendemails';
    //        $.post(url,
    //            {
    //                
    //                subject: "kh",
    //                body: bod
    //            },
    //            function (resp) {
    //                var formContent = $(resp);
    //                var dialog = $('<div>').attr('id', 'formDialog').html(formContent);
    //                $('body').append(dialog);
    //                dialog.dialog({
    //                    title: "Preview: " + $('#Subject').val(),
    //                    modal: true,
    //                    //                    open: function (event, ui) {                        
    //                    //                        var buttons = $(event.target).parent().find('.ui-dialog-buttonpane').children();
    //                    //                        buttons.removeClass('ui-button ui-widget ui-state-default ui-corner-all ui-button-text-only');
    //                    //                        buttons.addClass('dialog_button');
    //                    //                        //$(event.target).parent().find('.ui-dialog-buttonpane').removeClass('ui-dialog-buttonpane');
    //                    //                    },
    //                    buttons: {
    //                        'Cancel': function () { $(this).dialog('close'); },

    //                        'Send': function () {
    //                            //                    alert("Email Sent !");
    //                            var form = $("form");
    //                            $("#multiSelect").find('select.right').find('option').attr('selected', 'selected');

    //                            $.ajax({
    //                                url: form.attr('action'),
    //                                data: form.serialize(),
    //                                type: (form.attr('method')),
    //                                dataType: 'html',
    //                                completed: function () { },
    //                                success: function () { alert("Eximius is sending your emails !"); location.reload(); },
    //                                error: function (xmlHttpRequest, status, err) {
    //                                    alert(xmlHttpRequest.statusText + " " + xmlHttpRequest.status + " : " + xmlHttpRequest.responseText);
    //                                }
    //                            });
    //                            $(this).dialog('close');
    //                        }
    //                    },
    //                    close: function () { $(this).remove(); },
    //                    width: '950',
    //                    height: '500'
    //                });
    //            }, 'html');


    //    });

    //});

    $("#PreviewEmail").click(function () {

        var dialog = $('<div>').attr('id', 'formDialog').html("<div><label>Send To:</label><input type='text' id='destinationEmail' /> </div");
        $('body').append(dialog);
        dialog.dialog({
            title: "Preview Email ",
            modal: true,
            buttons: {
                'Cancel': function () { $(this).dialog('close'); },

                'Send': function () {
                    //                    alert("Email Sent !");
                    var form = $("#PreviewEmail").parents('form:first');
                    var bod = FCKeditorAPI.GetInstance('BodyEditor').GetHTML();
                    $('#Body').val(bod);
                    var url = '/tool/sendemails';
                    var previewMail = $("#destinationEmail").val();
                    $('#PreviewMail').val(previewMail);
                    //                    $.ajax({
                    //                        url: form.attr('action'),
                    //                        data: form.serialize() + '&PreviewMail=' + $("#destinationEmail").val() + '&Attach=' + $("#Attach").val() + '&Attach1=' + $("#Attach1").val() + '&Attach2=' + $("#Attach2").val() + '&Attach3=' + $("#Attach3").val() + '&Attach4=' + $("#Attach4").val() + '&Submit=Send',
                    //                        type: (form.attr('method')),
                    //                        dataType: 'html',
                    //                        completed: function () { },
                    ////                        success: function () { alert("BD is sending your preview email !"); },
                    ////                        error: function (xmlHttpRequest, status, err) {
                    ////                            alert(xmlHttpRequest.statusText + " " + xmlHttpRequest.status + " : " + xmlHttpRequest.responseText);
                    ////                        }
                    //                    });


                    $("#PreviewEmail").parents().find('form').ajaxSubmit();



                    $(this).dialog('close');
                }
            },
            close: function () { $(this).remove(); },
            width: '550',
            height: '300'
        });

    });


});

function BuildFCKEditor() {
    var sBasePath = "/Content/Editor/fckeditor/";
    var oFCKeditor = new FCKeditor('BodyEditor');
    oFCKeditor.BasePath = sBasePath;
    oFCKeditor.Height = 500;
    oFCKeditor.value = "";
    //    oFCKeditor.Create();
    oFCKeditor.ReplaceTextarea();
}

function BuildFCKEditorFR() {
    var sBasePath = "/Content/Editor/fckeditor/";
    var oFCKeditor = new FCKeditor('BodyEditorFR');
    oFCKeditor.BasePath = sBasePath;
    oFCKeditor.Height = 500;
    oFCKeditor.value = "";
    //    oFCKeditor.Create();
    oFCKeditor.ReplaceTextarea();
}


function FCKeditor_OnComplete() {
    var bod = $('#Body').val();
    FCKeditorAPI.GetInstance('BodyEditor').SetHTML(bod);

    var bodFR = $('#BodyFR').val();
    FCKeditorAPI.GetInstance('BodyEditorFR').SetHTML(bod);
}
