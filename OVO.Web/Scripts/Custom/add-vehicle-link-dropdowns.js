const $manufacturer = $("#manufacturer-select");
const $model = $("#model-select");

if ($manufacturer.html() && $model.html()) {
    document.getElementById("manufacturer-select").addEventListener("change", (ev) => {

        alert($(ev.target).val());
    }, null);
}

function filterByManufacturer(manufacturer) {

}