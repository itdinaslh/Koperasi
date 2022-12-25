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
            url: "/api/barang/jenis",
            type: "POST",
            dataType: "json"
        },
        columns: [
            { data: 'jenisBarangID', name: "jenisBarangID" },
            { data: "namaJenis", name: "namaJenis", autoWidth: true },
            {
                data: 'jenisBarangID',
                render: function (data, type, row) { return "<button type='button' class='btn btn-sm btn-success mr-2 showMe' style='width:100%;' data-href='/barang/jenis/edit/?id=" + row.jenisBarangID + "'> Edit</button>" }
            }
        ],
        order: [[0, "desc"]]
    })
}