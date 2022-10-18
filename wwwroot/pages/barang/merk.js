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
            url: "/api/barang/merk",
            type: "POST",
            dataType: "json"
        },
        columns: [
            { data: 'merkBarangId', name: "merkBarangId" },
            { data: "namaMerk", name: "namaMerk", autoWidth: true },
            { data: "namaJenis", name: "namaJenis", autoWidth: true },
            {
                data: 'merkBarangId',
                render: function (data, type, row) { return "<button type='button' class='btn btn-sm btn-success mr-2 showMe' style='width:100%;' data-href='/barang/merk/edit/?id=" + row.merkBarangId + "'> Edit</button>" }
            }
        ],
        order: [[0, "desc"]]
    })
}

$(document).on('shown.bs.modal', function () {
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
});

$(document).on('select2:open', () => {
    document.querySelector('.select2-search__field').focus();
});