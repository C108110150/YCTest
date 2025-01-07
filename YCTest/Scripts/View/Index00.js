$(function () {
    InlinePartialViewSubmit("QueryDocForm", "btnInsert", "divAdd", function () { });
    InlinePartialViewSubmit("QueryDocForm", "btnEdit", "divEdit", function () { });
    //tableDraw(queryTable, 'QueryDocForm', _queryTableConfig);
});


let _AddHousesDialogOption = {
    Data: {},
    Title: "房屋資訊-新增",
    DialogId: 'divAdd',
    Width: 1240,
    Height: 700,
    Url: '/Home/IndexA00',
    BeforeClose: function () { tableDraw(queryTable, 'QueryDocForm', _queryTableConfig); }
}

let _EditHousesDialogOption = {
    Data: {},
    Title: "房屋資訊-編輯",
    DialogId: 'divEdit',
    Width: 1240,
    Height: 700,
    Url: '/Home/IndexE00',
    BeforeClose: function () { tableDraw(queryTable, 'QueryDocForm', _queryTableConfig); }
}


function Delete_Houses(SerId) {
    if (confirm('是否要刪除資料?')) {
        $.ajax({
            url: '/BaseApi/DELETEHouses',
            type: "POST",
            dataType: "json",
            data: { SerId: SerId },
            success: function (response) {
                MessageShowDialog(response.Message, "訊息");
                tableDraw(queryTable, 'QueryDocForm', _queryTableConfig)
            },
            error: function (error) {
                MessageShowDialog("系統錯誤送出失敗!", "訊息");
            }
        });
    }
}