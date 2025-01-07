
function DeleteFile(index) {
    $('#picfileRow_' + index).hide();
    $('#IsDelete_' + index).val('true');
    var Count = parseInt($('#Listcount').val());
    $('#Listcount').val(Count - 1);
    updateFields();
}

function updateFields() {
    const maxCount = parseInt($('#maxcount').val());
    var upload = 0
    for (var i = 0; i < maxCount; i++) {
        upload += $('#Pic_' + i).val() ? 1 : 0;
    }

    var maxFields = maxCount - $('#Listcount').val() - upload;
    for (var i = 0; i < maxCount; i++) {
        if ($('#Pic_' + i).val()) {
            $('#uploadField' + i).show();
        } else if (maxFields && !$('#Pic_' + i).val()) {
            $('#uploadField' + i).show();
            maxFields = 0;
        } else {
            $('#uploadField' + i).hide();
        }
    }
}

function DeleteUpload(i) {
    $('#Pic_' + i).val(null);
    updateFields()

    const preview = document.getElementById(`previewPic${i}`);
    preview.setAttribute('src', '');
}

$(function () {
    const pics = [...document.querySelectorAll('.Pic')];
    const previews = [...document.querySelectorAll('.Preview')];

    $('#uploadFile').change(function (e) {
        let picIndex;
        pics.find((element, index) => {
            if (element === e.target) {
                picIndex = index;
                return true;
            }
        });
        
        const pic = pics[picIndex];
        var val = $(pic).val();
        switch (val.substring(val.lastIndexOf('.') + 1).toLowerCase()) {
            case 'png':
                if (pic.files[0].size > 104857600) {
                    $(pic).val('');
                    MessageShowDialog("檔案大小需小於100MB。請重新上傳檔案!!", "訊息");
                }
                break;
            case 'jpg':
                if (pic.files[0].size > 104857600) {
                    $(pic).val('');
                    MessageShowDialog("檔案大小需小於100MB。請重新上傳檔案!!", "訊息");
                }
                break;
            case 'jpeg':
                if (pic.files[0].size > 104857600) {
                    $(pic).val('');
                    MessageShowDialog("檔案大小需小於100MB。請重新上傳檔案!!", "訊息");
                }
                break;
            default:
                $(pic).val('');
                MessageShowDialog("檔案錯誤。檔案須為: PNG、JPG、JPEG。請重新上傳檔案!!");
                break;
        }

        updateFields();
        const preview = previews[picIndex];
        
        if (pic.value) {
            if (e.target.files && e.target.files[0]) {
                var reader = new FileReader();
                reader.onload = function (element) {
                    preview.setAttribute('src', element.target.result);
                    preview.style.display = 'block';
                };
                reader.readAsDataURL(e.target.files[0]);
            }
        } else {
            preview.setAttribute('src', '');
        }
    })
});
