(function () {
    'use script';

// hidden columns
new gridjs.Grid({
    columns: [{
        name: "Data",
        hidden: false,        
    }, {
        name: "Nome",
        width: "150px",
        hidden: false,
    }, {
        name: "Email",
        width: "200px",
    }, {
        name: "ID",
        width: "150px",
    }, {
        name: "Preço",
        width: "100px",
    }, {
        name: "Quantidade",
        width: "100px",
    }, {
        name: "Total",
        width: "100px",
    }],
    sort: true,
    search: true,
    pagination: true,
    data: [
        ["24-10-2022 12:47", "João", "john123@gmail.com", "#12012", "R$ 1799", "1", "R$ 1799"],
        ["12-09-2022 04:24", "Marcos", "markzenner23@gmail.com", "#12013", "R$ 2479", "2", "R$ 4958"],
        ["18-11-2022 18:43", "Helena", "helena1298@gmail.com", "#12014", "R$ 769", "1", "R$ 769"],
        ["10-09-2022 10:35", "Sara", "sarah129@gmail.com", "#12015", "R$ 1299", "3", "R$ 3997"],
        ["27-10-2022 09:55", "Ricardo", "ricardo5435110@example.com", "#12016", "R$ 1449", "1", "R$ 1449"]
    ],
}).render(document.getElementById("cooperchip-grid-hidden-column"));;
    // hidden columns

}) ();