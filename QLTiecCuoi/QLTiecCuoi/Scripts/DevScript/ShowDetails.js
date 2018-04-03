
$(document).ready(function () {
    $(".ajaxDetails").click(function () {
        $(".ajaxDetails").css("transform", "scale(0)");
        $(".section").css("opacity", "1");
    });
    $(".details").click(function (event) {
        event.preventDefault();
        $(".section").css("opacity", "0.3");
        $(".ajaxDetails").css("transform", "scale(1)");
        var id = $(this).attr('at');
        var checkPage = parseInt($(".check-page").val());
        switch (checkPage) {
            case 0:
                AjaxDetailsLoaiSanh(id);
                break;
            case 1:
                AjaxDetailsMonAn(id);
                break;
            case 2:
                AjaxDetailsDichVu(id);
                break;
        }
       /* if (checkPage === 0)
            AjaxDetailsLoaiSanh(id);
        else if (checkPage === 1)
            AjaxDetailsMonAn(id);*/
    });
    function AjaxDetailsLoaiSanh(id) {
        var url = "/LoaiSanh/DetailsAjax/" + id;
        $.ajax({
            url: url,
            type: 'get',
            dataType: 'json',
            success: function (result) {
                var strHTML = "";
                strHTML += "<tr>";
                strHTML += '<td class="form-group">';
                strHTML += '<label class="control-label col-md-5">Mã loại sảnh: </label>';
                strHTML += '<label class="control-label col-md-7">' + result["MaLoaiSanh"] + '</label>';
                strHTML += "</td>";
                strHTML += '<td class="form-group">';
                strHTML += '<label class="control-label col-md-5">Tên loại sảnh: </label>';
                strHTML += '<label class="control-label col-md-7">' + result["TenLoaiSanh"] + '</label>';
                strHTML += "</td>";
                strHTML += "</tr>";

                strHTML += "<tr>";
                strHTML += '<td class="form-group">';
                strHTML += '<label class="control-label col-md-5">Mã loại sảnh: </label>';
                strHTML += '<label class="control-label col-md-7">' + result["GiaBanToiThieu"] + '</label>';
                strHTML += "</td>";
                strHTML += '<td>';
                strHTML += '</td>';
                strHTML += "</tr>";
                $(".ajaxDetails tbody").html(strHTML);
            }
        });
    }
    function AjaxDetailsMonAn(id) {
        var url = "/MonAn/DetailsAjax/" + id;
        $.ajax({
            url: url,
            type: 'get',
            dataType: 'json',
            success: function (result) {
                var strHTML = "";
                // row 1
                strHTML += "<tr>";
                strHTML += '<td class="form-group">';
                strHTML += '<label class="control-label col-md-5">Mã món ăn: </label>';
                strHTML += '<label class="control-label col-md-7">' + result["MaMonAn"] + '</label>';
                strHTML += "</td>";
                strHTML += '<td class="form-group">'
                strHTML += '<label class="control-label col-md-5">Tên món ăn: </label>';
                strHTML += '<label class="control-label col-md-7">' + result["TenMonAn"] + '</label>';
                strHTML += '</td>';
                strHTML += "</tr>";
                // row 2
                strHTML += "<tr>";
                strHTML += '<td class="form-group">';
                strHTML += '<label class="control-label col-md-5">Giá món ăn: </label>';
                strHTML += '<label class="control-label col-md-7">' + result["GiaMonAn"] + '</label>';
                strHTML += "</td>";
                strHTML += '<td class="form-group">'
                strHTML += '<label class="control-label col-md-5">Ghi chú: </label>';
                strHTML += '<label class="control-label col-md-7">'
                    + ifValueNullShowEmpty(result["GhiChi"]) + '</label>';
                strHTML += '</td>';
                strHTML += "</tr>";
                $(".ajaxDetails tbody").html(strHTML);
            }
        });
    }
    function AjaxDetailsDichVu(id) {
        var url = "/DichVu/DetailsAjax/" + id;
        $.ajax({
            url: url,
            type: 'get',
            dataType: 'json',
            success: function (result) {
                var strHTML = "";
                // row 1
                strHTML += '<tr>';
                strHTML += '<td class="form-group">';
                strHTML += '<label class="control-label col-md-5">Mã dịch vụ: </label>';
                strHTML += '<label class="control-label col-md-5">' + ifValueNullShowEmpty(result["MaDV"]) + '</label>';
                strHTML += '</td>';
                strHTML += '<td class="form-group">';
                strHTML += '<label class="control-label col-md-5">Tên dịch vụ: </label>';
                strHTML += '<label class="control-label col-md-5">' + ifValueNullShowEmpty(result["TenDV"]) + '</label>';
                strHTML += '</td>';
                strHTML += '</tr>';
                // row 2
                strHTML += '<tr>';
                strHTML += '<td class="form-group">';
                strHTML += '<label class="control-label col-md-5">Giá dịch vụ: </label>';
                strHTML += '<label class="control-label col-md-5">' + ifValueNullShowEmpty(result["GiaDV"]) + '</label>';
                strHTML += '</td>';
                strHTML += '<td class="form-group">';
                strHTML += '</td>';
                strHTML += '</tr>';

                $(".ajaxDetails tbody").html(strHTML);
            }
        });
    }
    function ifValueNullShowEmpty(value) {
        return (value === null) ? "" : value;
    }
});
