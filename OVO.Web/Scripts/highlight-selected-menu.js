document.getElementsByClassName("menu")[0].addEventListener("click", (ev) => {
    //$(".menu a.active").first().removeClass("active");
    //$(ev.target).addClass("active");
    //alert($(ev.target).attr("class"));
    $(".menu a").addClass("active");
});