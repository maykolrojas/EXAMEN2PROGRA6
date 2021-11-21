"use strict";
var OrdenEdit;
(function (OrdenEdit) {
    var Formulario = new Vue({
        data: {
            Formulario: "#FormEdit"
        },
        mounted: function () {
            CreateValidator(this.Formulario);
        }
    });
    Formulario.$mount("#AppEdit");
})(OrdenEdit || (OrdenEdit = {}));
//# sourceMappingURL=Edit.js.map