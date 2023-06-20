$(document).ready(function () {
    loadTable();
});

function loadContent() {
    loadTable();
}

function loadTable() {
    $('#tblData').DataTable().clear().destroy();
    $('#tblData').DataTable({
        processing: false,
        serverSide: true,
        lengthMenu: [5, 10, 25, 50],
        stateSave: true,
        filter: true,
        orderMulti: false,
        language: {
            paginate: {
                next: '<i class="fa fa-angle-double-right" aria-hidden="true"></i>',
                previous: '<i class="fa fa-angle-double-left" aria-hidden="true"></i>'
            }
        },
        ajax: {
            url: "/api/barang/tipe",
            type: "POST",
            dataType: "json"
        },
        columns: [
            { data: 'tipeBarangId', name: "tipeBarangId" },
            { data: "namaTipe", name: "namaTipe", autoWidth: true },
            { data: "namaMerk", name: "namaMerk", autoWidth: true },
            { data: "namaJenis", name: "namaJenis", autoWidth: true },
            {
                data: 'tipeBarangId',
                render: function (data, type, row) { return "<button type='button' class='btn btn-sm btn-success mr-2 showMe' style='width:100%;' data-href='/barang/tipe/edit/?id=" + row.tipeBarangId + "'> Edit</button>" }
            }
        ],
        order: [[0, "desc"]]
    })
}

$(document).on('shown.bs.modal', function () {
    jenis();
    $('#sJenis').change(function () {
        $('#sMerk').val(null).trigger('change');
        var theID = $('#sJenis option:selected').val();
        merk(theID);
        $('#sMerk').select2('focus');
    });
    
});

$(document).on('select2:open', () => {
    document.querySelector('.select2-search__field').focus();
});

function jenis() {
    $('#sJenis').select2({
        placeholder: 'Pilih Jenis Barang...',
        dropdownParent: $('#myModal'),
        allowClear: true,
        ajax: {
            url: "/api/barang/jenis/search",
            contentType: "application/json; charset=utf-8",
            data: function (params) {
                var query = {
                    term: params.term,
                };
                return query;
            },
            processResults: function (result) {
                return {
                    results: $.map(result, function (item) {
                        return {
                            text: item.namaJenis,
                            id: item.id
                        }
                    })
                }
            },
            cache: true
        }
    });
}
function merk(jenis) {
    $('#sMerk').select2({
        placeholder: 'Pilih Jenis Barang...',
        dropdownParent: $('#myModal'),
        allowClear: true,
        ajax: {
            url: "/api/barang/merk/search?jenis=" + jenis,
            contentType: "application/json; charset=utf-8",
            data: function (params) {
                var query = {
                    term: params.term,
                };
                return query;
            },
            processResults: function (result) {
                return {
                    results: $.map(result, function (item) {
                        return {
                            text: item.namaMerk,
                            id: item.id
                        }
                    })
                }
            },
            cache: true
        }
    });
}