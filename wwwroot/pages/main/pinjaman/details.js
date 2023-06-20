$(document).ready(function () {
    loadTable();

});
$(document).on('shown.bs.modal', function () {
    Nik();
    Bulan();
});

function loadContent() {
    loadTable();
}

function loadTable() {
    $('#tblData').DataTable({
        language: {
            paginate: {
                next: '<i class="fa fa-angle-double-right" aria-hidden="true"></i>',
                previous: '<i class="fa fa-angle-double-left" aria-hidden="true"></i>'
            }
        }
    });
}

function Nik() {
    $('#sNik').select2({
        placeholder: 'Pilih NIK ...',
        dropdownParent: $('#myModal'),
    });
}

function Bulan() {
    $('#sBulan').select2({
        placeholder: 'Pilih Bulan ...',
        dropdownParent: $('#myModal'),
    });
}