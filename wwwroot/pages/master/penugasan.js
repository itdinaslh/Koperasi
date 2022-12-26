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
            url: "/api/master/penugasan",
            type: "POST",
            dataType: "json"
        },
        columns: [
            { data: 'penugasanID', name: "penugasanID"},
            { data: "namaPenugasan", name: "namaPenugasan", autoWidth: true },            
            {
                data: 'penugasanID',
                render: function (data, type, row) {
                    return `<div class="dropdown-center ms-auto text-center">
                                <div class="btn-link" data-bs-toggle="dropdown">
                                    <svg width="24px" height="24px" viewBox="0 0 24 24" version="1.1"><g stroke="none" stroke-width="1" fill="none" fill-rule="evenodd"><rect x="0" y="0" width="24" height="24"></rect><circle fill="#000000" cx="5" cy="12" r="2"></circle><circle fill="#000000" cx="12" cy="12" r="2"></circle><circle fill="#000000" cx="19" cy="12" r="2"></circle></g></svg>
                                </div>
                                <div class="dropdown-menu">
                                    <a class="dropdown-item showMe" href="javascript:void(0)" data-href="/master/penugasan/edit/?id=` + row.penugasanID + `">Edit</a>
                                </div>
                            </div>`
                }
            }
        ],
        order: [[0, "desc"]]
    })
}