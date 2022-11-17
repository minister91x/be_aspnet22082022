AddItemToCart = function (e) {
    debugger;
    
    var item = {
        ProductID: $("#txtProductIDBuy").val(),
        ProductName: $(e).data('productname'),
        Quality: 1,
        CustomPrice: $("#txtProductSalePriceBuy").val(),
        Image: $(e).data('image')
    };
    console.log(item);
    if (item.ProductID == 0) {
        $("#btnAddtoCartErr").show();
        $("#btnAddtoCartErr").text("Vui lòng chọn  ít nhất 01 " + $("#txtProductAttrGroupNameBuy").val(), 0);
        return;
    } else {
        $("#btnAddtoCartErr").hide();
    }
    var store = GetCookie('ShoppingCart');
    store = AddAndUpdateShoppingCart(store, item);

    UpdateShoppingCartView(store, 1, "");
}


AddItemFromChangeQuantityToCart = function (e, productid) {

    var quantity = $("#txtQuantity_" + productid).val();
    quantity = parseInt(quantity, 10);

    var price = parseInt($(e).data('price'), 10);
    //if (quantity > 0) {
    //    if (quantity > 10) {
    //        $("#txtQuantity_" + productid).val(10);
    //        $("#TotalAmount_" + productid).text(FormatMoney(price * 10));
    //    }
    //    $("#TotalAmount_" + productid).text(FormatMoney(price * parseInt(quantity, 10)));
    //} else {
    //    $("#txtQuantity_" + productid).val(1);
    //    $("#TotalAmount_" + productid).text(FormatMoney(price));
    //}

    var item = {
        ProductID: $(e).data('product'),
        ProductName: $(e).data('productname'),
        Quality: quantity,
        CustomPrice: price,
        Image: $(e).data('image')

    };

    var store = GetCookie('ShoppingCart');
    store = AddAndUpdateShoppingCart(store, item, quantity);

    UpdateShoppingCartView(store, 2);

}

AddItemByQuantityFromProductDetailToCart = function (e, productid) {

    var quantity = $("#txtQuantity_" + productid).val();
    quantity = parseInt(quantity, 10);
    var price = parseInt($(e).data('price'), 10);

    var item = {
        ProductID: $(e).data('product'),
        ProductName: $(e).data('productname'),
        Quality: quantity,
        CustomPrice: price,
        Image: $(e).data('image')

    };

    var store = GetCookie('ShoppingCart');
    store = AddAndUpdateShoppingCart(store, item, quantity);

    var html_item = "";
    html_item += "<div class=\"p-3 cart-block\" style=\"width: 450px !important\">";
    html_item += "<div class=\"row mx-0 mb-3\">";
    html_item += "<div class=\"col-4 p-0\" > ";
    html_item += "<img src=\"" + $(e).data('image') + "\" alt=\"\" class=\"w-100\" style=\"padding-top: 20px;\"></a>";
    html_item += " </div>";
    html_item += "<div class=\"col-8\">";
    html_item += "<h4 style=\"padding-top: 10px;\"><a href=\"#\" class=\"fables-main-text-color font-13 d-block fables-main-hover-color\">" + $(e).data('productname') + "</a></h4>";
    html_item += "<p class=\"fables-second-text-color font-weight-bold\">";
    html_item += "<span class=\"fables-iconprice\"></span>";
  
    html_item += " </p>";
    html_item += "<p class=\"fables-forth-text-color\">Số lượng:" + quantity + "</p>";
    html_item += "</div>";
    html_item += "</div>";
    html_item += "</div>";
    UpdateShoppingCartView(store, 1, html_item);

}


RemoveItemFromCart = function (e) {

    var result = confirm("Bạn có chắc chắn muốn xóa sản phẩm này ?");
    if (result) {
        var item = {
            ProductID: $(e).data('product'),
            ProductName: $(e).data('productname'),
            Quality: $(e).data('quantity'),
            CustomPrice: $(e).data('price_sale'),
            Image: $(e).data('image')

        };
        var store = GetCookie('ShoppingCart');
        store = RemoveItemFromShoppingCart(store, item);
        UpdateShoppingCartView(store, 2);

        window.location.href = utils.rootUrl() + "gio-hang";
    }


}


AddAndUpdateShoppingCart = function (store, item, quantity) {
    console.log(store);
    console.log(item);
    var index = store.findIndex(function (d) {
        return d.ProductID == item.ProductID && d.AttrID == item.AttrID;
    });
    if (store.length == 0 || index == -1) {
        store.push(item);
        SetCookie('ShoppingCart', store);
        return store;
    }
    if (quantity != null && quantity != "undefined") {
        store[index].Quality = quantity;
    } else {
        store[index].Quality = parseInt(store[index].Quality) + 1;
    }
    SetCookie('ShoppingCart', store);
    return store;
}

RemoveItemFromShoppingCart = function (store, item) {

    if (store.length > 0) {
        var index = store.findIndex(function (d) {
            return d.ProductID == item.ProductID;
        });

        store.splice(index, 1);
        SetCookie('ShoppingCart', store);
        return store;
    }
    //store[index].Quality = parseInt(store[index].Quality) - 1;
    //SetCookie('ShoppingCart', store);
    //return store;
}

UpdateShoppingCartView = function (store, type, html_popup) {
    if (store == undefined || store == null || store.length == 0)
        store = GetCookie('ShoppingCart');
    var countPrice = 0;
    $('.header-icons-noti').html(store.length);
    $.each(store, function (i, d) {
        countPrice += parseFloat(d.CustomPrice) * parseFloat(d.Quality)
    });
    
    if (type == 1) {

       alert("Thêm vào giỏ hàng thành công!")
    }
}

UpateListCartInHeader = function () {
    var inputdata = {};

    $.ajax({
        type: "GET",
        url: "/CustomViews/ListCartHeaderPartial",
        data: inputdata,
        contentType: "application/json; charset=utf-8",
        dataType: "html",
        success: function (data) {
            $("#list_cart_header").html("");
            $("#list_cart_header").html(data);
        },
        error: function (data) { console.log("ShopCategory:" + JSON.stringify(data)); },
    });
}

CalcMinusorPlusQuantity = function (type, productid) {
    var $input_quantity = $("#txtQuantity_" + productid);
    var q = $("#txtQuantity_" + productid).val();

    // giảm số lượng
    if (type == 1) {
        if (parseInt(q, 10) > 1) {
            $input_quantity.val(parseInt($input_quantity.val()) - 1);
        }
    }
    // tăng số lượng
    if (type == 2) {
        $input_quantity.val(parseInt($input_quantity.val()) + 1);
    }

}


$(function () {
    UpdateShoppingCartView();
    InitNumber();
});
InitNumber = function () {
    $('#btn-num-product-down').on('click', function () {
        var numProduct = Number($(this).next().val());
        var price = $(this).data('price');
        if (numProduct > 1) {
            var productid = $(this).data('productid');
            var quantity = parseInt(numProduct, 10) - 1;
            $(this).next().val(quantity);
           /* $("#TotalAmount_" + productid).text(FormatMoney(price * (numProduct - 1)));*/
            UpdateCountPrice();

            var item = {
                ProductID: $(this).data('productid')
            };

            var store = GetCookie('ShoppingCart');

            var index = store.findIndex(function (d) {
                return d.ProductID == item.ProductID;
            });

            if (store.length == 0 || index == -1) {
                return;
            }

            store[index].Quality = quantity;
            SetCookie('ShoppingCart', store);
        }
    });

    $('#btn-num-product-up').on('click', function () {
        debugger
        var numProduct = Number($(this).prev().val());
        if (numProduct >= 10) { return; }
        var price = $(this).data('price');
        var productid = $(this).data('productid');
        $(this).prev().val(numProduct + 1);
        var quantity = numProduct + 1;
       /* $("#TotalAmount_" + productid).text(FormatMoney(price * (numProduct + 1)));*/
        UpdateCountPrice();
        var item = {
            ProductID: $(this).data('productid')
        };

        var store = GetCookie('ShoppingCart');

        var index = store.findIndex(function (d) {
            return d.ProductID == item.ProductID;
        });

        if (store.length == 0 || index == -1) {
            return;
        }

        store[index].Quality = quantity;
        SetCookie('ShoppingCart', store);

    });

}

UpdateCountPrice = function () {
    var count = 0;

    $('.column-5').each(function (d) {
        var price = $(this).html().replace("₫", "").replace(/!|@|%|\^|\*|\(|\)|\+|\=|\<|\>|\?|\/|,|\.|\:|\;|\'| |\"|\&|\#|\[|\]|~|$|_/g, '');
        count += parseInt(price);
    });
   /* $('#Cart_totalAmount').html(FormatMoney(count));*/
}


CreateOrder = function () {
    debugger;

    var CustomerName = $("#txt_customer_name").val();
    var CustomerPhone = $("#txt_customer_phone").val();
    var CustomerEmail = $("#txt_customer_email").val();
    var Address = $("#txt_customer_address").val();
    var total_price = $("#cart_total_payment").text();

    var note = $("#txt_Note").val();


    var provinceID = $("#customer_shipping_province").val()
    var disctricID = $("#customer_shipping_district").val();
    var WardCode = $("#customer_shipping_ward").val();
    var discountCode = $("#discount_code").val();
    if (discountCode == null || discountCode == null) { discountCode = ""; }

    //$('.column-5').each(function (d) {
    //    var price = $(this).html().replace("₫", "").replace(/!|@|%|\^|\*|\(|\)|\+|\=|\<|\>|\?|\/|,|\.|\:|\;|\'| |\"|\&|\#|\[|\]|~|$|_/g, '');
    //    total_amount += parseInt(price);
    //});

    if (total_price != null && total_price != null) {
        total_price = total_price.replace("₫", "").replace(/!|@|%|\^|\*|\(|\)|\+|\=|\<|\>|\?|\/|,|\.|\:|\;|\'| |\"|\&|\#|\[|\]|~|$|_/g, '');
    }
    var phone_regex = /((09|03|07|08|05)+([0-9]{8})\b)/g;
    var email_regex = /^([a-zA-Z0-9_\.\-])+\@(([a-zA-Z0-9\-])+\.)+([a-zA-Z0-9]{2,4})+$/;

    if (CustomerName == "" || CustomerName == null) {
        Swal.fire("", "Bạn chưa nhập Họ tên", "warning")
        return;
    }

    if (CustomerPhone == "" || CustomerPhone == null) {
        Swal.fire("", "Số điện thoại không chính xác", "warning")
        return;
    }

    if (phone_regex.test(CustomerPhone) == false) {
        Swal.fire("", "Số điện thoại của bạn không đúng định dạng!");
        return;
    }


    if (Address == "" || Address == null) {

        Swal.fire("", "Bạn chưa nhập địa chỉ", "warning")
        return;
    }

    if (note == '' || note == null) {
        Swal.fire("", "Bạn chưa nhập nội dung ghi chú", "warning")
        return;
    }

    if (provinceID == '' || provinceID == null || provinceID <= 0) {
        Swal.fire("", "Vui lòng chọn tỉnh /thành phố", "warning");
        return;
    }

    if (disctricID == '' || disctricID == null || disctricID <= 0) {
        Swal.fire("", "Vui lòng chọn Quận/Huyện", "warning")
        return;
    }
    if (WardCode == '' || WardCode == null) {
        Swal.fire("", "Vui lòng chọn Phường /Xã", "warning")
        return;
    }
    var order = {
        TotalPrice: total_price.replace("VNĐ", ""),
        FullName: CustomerName.trim(),
        Email: CustomerEmail.trim(),
        Address: Address.trim(),
        PhoneNumber: CustomerPhone,
        GhiChu: note.trim(),
        ProvinceID: provinceID,
        DisctricID: disctricID,
        WardCode: WardCode,
        DiscountCode: discountCode


    };
    var Url = utils.rootUrl() + "ShoppingCart/CreateOrder";

    $.ajax({
        type: 'POST',
        url: Url,
        data: order,
        success: function (data) {
            var responseCode = data.ResponseCode;
            var description = data.Description;
            if (responseCode > 0) {

                document.cookie = 'ShoppingCart' + '=; expires=Thu, 01-Jan-70 00:00:01 GMT;';
                Swal.fire("Đặt hàng thành công", "Chúng tôi sẽ liên hệ lại với bạn để xác nhận", "success", {
                    buttons: false,
                    timer: 3000,
                });
                return;
            } else {
                Swal.fire("", description, "warning")
                return;
            }

        },
        error: function (data) {
            console.log("error:" + JSON.stringify(data));
        }
    });
}

GetDistricByProvinceId = function (id) {
    var html = "";
    var Url = Utils.rootUrl() + "ShoppingCart/GetDistrictByProvinceId";
    var inputdata = { provinceId: id };
    //  Utils.Loading();
    $.ajax({
        type: 'GET',
        url: Url,
        data: inputdata,
        success: function (data) {
            // Utils.UnLoading();

            for (var i = 0; i < data.length; i++) {
                var item = data[i];
                html += "<option value='" + item.Id + "'>" + item.Name + "</option>";
            }

            $("#ddlDistric").html('');
            $("#ddlDistric").html(html);

            GetCommonueByDistricID($('#ddlDistric').val());
        },
        error: function (data) {
            console.log("error:" + JSON.stringify(data));
        }
    });
}


checkIsMobileDevice = function () {
    var isiPhone = navigator.userAgent.toLowerCase().indexOf("iphone");
    var isiPod = navigator.userAgent.toLowerCase().indexOf("ipod");
    var isAndroid = /android/i.test(navigator.userAgent.toLowerCase());
    var isBlackberry = navigator.userAgent.toLowerCase().indexOf("BlackBerry");
    var isOpera = /Opera/i.test(navigator.userAgent.toLowerCase());
    var isIE = navigator.userAgent.toLowerCase().indexOf("IEMobile");
    var isWinPhone = navigator.userAgent.toLowerCase().indexOf("windows phone");

    if (isiPhone > -1) return true;
    if (isiPod > -1) return true;
    if (isAndroid) return true;
    if (isBlackberry > -1) return true;
    if (isOpera) return true;
    if (isIE > -1) return true;
    if (isWinPhone > -1) return true;
    return false;
}
