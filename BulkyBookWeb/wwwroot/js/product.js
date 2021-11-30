var dataTable;

$(document).ready(function () {
    loadDataTable();
});

function loadDataTable() {
    dataTable = $('#tblData').DataTable({
        "ajax": {
            "url": "/Admin/Product/GetAll"
        },
        "columns": [
            {
                "data": "title",
                "width": "15%"
            },
            {
                "data": "isbn",
                "width": "15%"
            },
            {
                "data": "price",
                "width": "15%"
            },
            {
                "data": "author",
                "width": "15%"
            },
            {
                "data": "category.name",
                "width": "15%"
            },
            {
                "data": "id",
                "render": function (data) {
                    return `
                       <div class="w-75 btn-group" role="group">
                           <a class="btn btn-primary" href="/Admin/Product/Upsert?id=${data}" > <i class="bi bi-pen"></i> Editează</a>
                           <a class="btn btn-danger" > <i class="bi bi-trash-fill"></i>Șterge</a>
                       </div>
                       `
                },
                "width": "15%"
            }
        ]
    })
}