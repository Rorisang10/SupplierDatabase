function saveSupplier() {
    var company = $("#companyName").val();
    var telephone = $("#telephone").val();

    var supplier = { Company: company, Telephone: telephone };
    $.post("/api/suppliers", supplier, function () {
        alert("Supplier saved successfully!");
    });
}

function searchSupplier() {
    var company = $("#searchCompany").val();
    $.get("/api/suppliers/search?company=" + company, function (telephone) {
        $("#result").text("Telephone: " + telephone);
    }).fail(function () {
        $("#result").text("Supplier not found.");
    });
}
