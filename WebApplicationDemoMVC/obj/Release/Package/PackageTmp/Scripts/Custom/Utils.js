Utils = new function () {

    this.ValidateData = function (tag_html_id, tag_html_notify) {

        var html_tag_value = $("#" + tag_html_id).val();

        console.log("username data:" + html_tag_value);

        if (html_tag_value == null || html_tag_value == "") {
            $("#" + tag_html_notify).show();
            $("#" + tag_html_notify).text("trường này phải có dữ liệu")
            $("#" + tag_html_id).css("border", "1px solid red");
            $("#" + tag_html_id).focus();
            return;
        } else {
            $("#" + tag_html_notify).hide();
            $("#" + tag_html_id).css("border", "");

        }
    },

        this.rootUrl = function () {
            var rooturl = 'http://localhost:51227/';
            if (location.host.toString().indexOf('localhost') >= 0) { rooturl = 'http://localhost:51227/'; }
            if (location.host.toString().indexOf('islickdeals') >= 0) { rooturl = 'http://localhost:51227/'; }
            return rooturl;
        },
        this.CheckOnlyNumber = function (obj, e) {
            var whichCode = (window.Event && e.which) ? e.which : e.keyCode; /*if (whichCode == 13) { this.onPlaceOrder(); return false; }*/
            if (whichCode == 9) return true;
            if ((whichCode >= 48 && whichCode <= 57) || whichCode == 8) {
                var n = obj.value.replace(/,/g, "");
                if (whichCode == 8) {
                    if (n.length != 0)
                        n = n.substr(0, n.length - 1);
                }
                if (parseFloat(n) == 0) {
                    n = '';
                }
                return true;
            }
            e.returnValue = false;
            return false;
        };
    this.FormatCurrency = function (ctrl) {
        debugger;
        //Check if arrow keys are pressed - we want to allow navigation around textbox using arrow keys
        if (event.keyCode == 37 || event.keyCode == 38 || event.keyCode == 39 || event.keyCode == 40) {
            return;
        }
        var val = ctrl.value;
        val = val.replace(/[.,]/g, "");
        ctrl.value = "";
        val += '';
        var x = val.split('.');
        var x1;
        x1 = x[0];
        var x2 = x.length > 1 ? '.' + x[1] : '';
        var rgx = /(\d+)(\d{3})/;
        //custom dot (.) or comma(,) here
        while (rgx.test(x1)) {
            x1 = x1.replace(rgx, '$1' + '.' + '$2');
        }
        ctrl.value = x1 + x2;
    }
}