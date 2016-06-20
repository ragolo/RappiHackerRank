var RappiServices = (function() {
    return {
        UploadFiles: function (url, data) {
            // Create a Deferred
            var defer = $.Deferred();
            defer.promise(this);

            $.ajax({
                type: "POST",
                url: url,
                contentType: false,
                processData: false,
                data: data,
                success: function (result) {
                    if (result.success) {
                        defer.resolve(result.result);
                    } else {
                        defer.reject(result.error);
                    }
                },
                error: function (xhr, status, p3, p4) {
                    var err = "Error " + " " + status + " " + p3 + " " + p4;
                    if (xhr.responseText && xhr.responseText[0] == "{")
                        err = JSON.parse(xhr.responseText).Message;
                    defer.reject(err);
                }
            });
            return defer.promise();
        }
    };
})();