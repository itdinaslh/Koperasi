$(document).ready(function () {
    loadTable();
    tahun();
    bulan();
    status();
});

$(document).on('shown.bs.modal', function () {
    bulan();
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

function tahun() {
    $('#sTahun').select2({
    placeholder: 'Pilih Tahun...',
    });
}
function bulan() {
    $('.sBulan').select2({
    placeholder: 'Pilih Bulan...',
    });     
}
function status() {
    $('#sStatus').select2({
        placeholder: 'Pilih Status...',
    });
}