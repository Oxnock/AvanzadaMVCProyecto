jQuery(document).ready(function () {
    jQuery('.dataTable').DataTable({
        "language": {
            "url": "https://cdn.datatables.net/plug-ins/9dcbecd42ad/i18n/Spanish.json"
        },
        responsive: true
    })
});

$(document).ready(function () {
    $(".del").click(function () {
        if (!confirm("¿Estas seguro que deseas eliminar?")) {
            return false;
        }
    });
});

//No spaces
jQuery(document).ready(function () {
    jQuery('.spaces').keyup(function (e) {
        var value = jQuery(this).val();
        if (value == " ") {
            jQuery(this).val("");
        }
    });

});
