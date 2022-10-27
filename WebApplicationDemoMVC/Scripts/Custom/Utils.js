window.Utils = {

    ValidateData: function (tag_html_id, tag_html_notify) {

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

    rootUrl: function () {
        var rooturl = 'http://localhost:11339/';
        if (location.host.toString().indexOf('localhost') >= 0) { rooturl = 'http://localhost:11339/'; }
        if (location.host.toString().indexOf('islickdeals') >= 0) { rooturl = 'http://localhost:11339/'; }
        return rooturl;
    },
  
}