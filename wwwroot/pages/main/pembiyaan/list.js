$(document).ready(function () {
    loadTable();

});
$(document).on('shown.bs.modal', function () {
    Nik();
    Jenis();
    Merk();
    NamaBarang();
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

function Jenis() {
    $('#sJenis').select2({
        placeholder: 'Pilih Jenis ...',
        dropdownParent: $('#myModal'),
    });
}

function Merk() {
    $('#sMerk').select2({
        placeholder: 'Pilih Merk ...',
        dropdownParent: $('#myModal'),
    });
}

function NamaBarang() {
    $('#sBarang').select2({
        placeholder: 'Pilih Nama Barang ...',
        dropdownParent: $('#myModal'),
    });
}