window.onload = () => {
    const url = window.location.href;
    const urlParts = url.split("/");
    const menuElements = $("header ul li").length;

    $("header ul li").removeClass("active");

    if (menuElements === 3) {
        if (urlParts.length < 5) {
            $("header ul li:nth-child(1)").addClass("active");
        } else if (urlParts[urlParts.length - 1] === "chat") {
            $("header ul li:nth-child(2)").addClass("active");
        } else if (urlParts[urlParts.length - 1] === "contact") {
            $("header ul li:nth-child(3)").addClass("active");
        }
    } else if (menuElements === 4) {
        if (urlParts.length < 5) {
            $("header ul li:nth-child(2)").addClass("active");
        } else if (urlParts[urlParts.length - 1] === "all") {
            $("header ul li:nth-child(1)").addClass("active");
        } else if (urlParts[urlParts.length - 1] === "chat") {
            $("header ul li:nth-child(3)").addClass("active");
        } else if (urlParts[urlParts.length - 1] === "contact") {
            $("header ul li:nth-child(4)").addClass("active");
        }
    } else {
        if (urlParts.length < 5) {
            $("header ul li:nth-child(2)").addClass("active");
        } else if (urlParts[urlParts.length - 1] === "chat") {
            $("header ul li:nth-child(3)").addClass("active");
        } else if (urlParts[urlParts.length - 1] === "contact") {
            $("header ul li:nth-child(4)").addClass("active");
        }
    }
};


