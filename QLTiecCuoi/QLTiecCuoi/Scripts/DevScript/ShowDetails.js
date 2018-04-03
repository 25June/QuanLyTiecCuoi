console.log("asd");
$(document).ready(function () {
    $(".ajax").click(function () {
        $(".ajax").css("transform", "scale(0)");
        $(".section").css("opacity", "1");
    });
    $(".details-loai-sanh").click(function () {
        $(".section").css("opacity", "0.3");
        $(".ajax").css("transform", "scale(1)");
        var kq = $(this).attr('at');
        var url = 'LoaiSanh/DetailsTest/' + kq;
        console.log(url);
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
                $(".ajax tbody").html(strHTML);
            }
        });
    });
});