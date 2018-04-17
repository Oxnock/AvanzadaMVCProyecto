﻿
jQuery(document).ready(function () {
  

//No numbers
    jQuery('.not-number').keyup(function (e) {
        if (!/^[ a-záéíóúüñ]*$/i.test(this.value)) {
            this.value = this.value.replace(/[^ a-záéíóúüñ]+/ig, "");
        }
    });

//Id validation
    jQuery('#identificacion').change(function (e) {
        if (this.value == "Nacional") {
            jQuery('#cedula').attr("min", "100000000");
            jQuery('#cedula').attr("max", "999999999");
            jQuery('#cedula').attr("type", "number");
        } else {
            jQuery('#cedula').removeAttr("min");
            jQuery('#cedula').removeAttr("max");
            jQuery('#cedula').attr("type", "text");
        }
    });

 //No spaces
    jQuery('.no-espacios').keyup(function (e) {
        var value = jQuery(this).val();
        if (value == " ") {
            jQuery(this).val("");
        }
    });

//?
    jQuery(".editar-usuario").click(function () {
        jQuery(".titulo-form-usuario").html("Editar usuario");
    });
    jQuery(".nuevo-usuario").click(function () {
        jQuery(".titulo-form-usuario").html("Nuevo usuario");
    });
});

function myFunctionDelete() {
    alert("El usuario se borrará.");
}	
});