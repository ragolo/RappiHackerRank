var Cube3dData = (function () {
    var main = this;
    main.Cube3DModel = function (item) {
        this.item = item;
    };
    return {
        registerViewModel: function () {
            var self = this;
            self.master = ko.observableArray([]);
            self.error = ko.observable();
            self.btnProcesar = function () {
                var fileInput = document.getElementById("txtUploadFile");
                var files = fileInput.files;

                if (files.length > 0) {
                    if (window.FormData !== undefined) {
                        var data = new FormData();
                        for (var x = 0; x < files.length; x++) {
                            data.append("file" + x, files[x]);
                        }

                        RappiServices.UploadFiles("Home/ProcessCubeSummation3D", data)
                            .done(function (response) {
                                if (self.master().length > 0) {
                                    self.master.removeAll();
                                }
                                $.each(response, function (idx, item) {
                                    self.master.push(new main.Cube3DModel(item));
                                });
                            })
                            .fail(function (error) {
                                self.error(error);
                                $('#modalError').modal({ keyboard: false });
                            });
                    } else {
                        alert("This browser doesn't support HTML5 file uploads!");
                    }
                } else {
                    self.error('Por favor seleccione un archivo a procesar');
                    $('#modalError').modal({ keyboard: false });
                }
            };

        }
    };
})();
ko.applyBindings(new Cube3dData.registerViewModel(), document.getElementById('uploadFileCube3d'));