const $manufacturer = $("#manufacturer-select");
const $model = $("#model-select");

if ($manufacturer.html() && $model.html()) {
    document.getElementById("manufacturer-select").addEventListener("change", (ev) => {
        const selectedManId = $(ev.target).val();
        filterByManufacturer(selectedManId);
    }, null);

    init();
}

function init() {
    if ($manufacturer.val()) {
        const selectedManId = $manufacturer.val();
        filterByManufacturer(selectedManId);
    } else {
        $model.children().toArray().forEach(x => {
            $(x).hide();
        });
    }
}

function filterByManufacturer(manufacturerId) {
    $model.children().toArray().forEach(x => {
        const $mod = $(x);
        $mod.hide();
        if ($mod.attr("man") === manufacturerId) {
            $mod.show();
        }
    });
}