$.connection.hub.start();
const chat = $.connection.chatHub;

chat.client.addMessage = (msg, user) => {
    updateChat(msg, user);
}

chat.client.joinUser = (user, users) => {
    attachUser(user, users);
}

chat.client.disconnectUser = (user) => {
    detachUser(user);
}

$chatBoard = $("#chatBoard");
$msgText = $("#messageText");
msgText = document.getElementById("messageText");
sendBtn = document.getElementById("chatBtn");
$usersList = $("#usersList");

sendBtn.addEventListener("click", () => {
    if ($msgText.val().trim()) {
        chat.server.sendMessage($msgText.val());
    } else {
        $msgText.val("");
    }
});

msgText.addEventListener("keyup", (ev) => {
    if (ev.key === "Enter") {
        if ($msgText.val().trim()) {
            chat.server.sendMessage($msgText.val());
        } else {
            $msgText.val("");
        }
    }
});

function updateChat(message, user) {
    let username = "Anonimous";
    if (user) {
        username = user;
    }

    let dateTime = new Date().toLocaleString();
    let elem = document.createElement("p");
    let formattedMsg = "<span style='color: darkblue;'><i>" + dateTime + "</i></span> <strong>" + username + "</strong>: " + message;
    
    let $newMsg = $(elem).html(formattedMsg);
    $newMsg.appendTo($chatBoard);
    $msgText.val("");

    $("#chatBoard").scrollTop($("#chatBoard")[0].scrollHeight);
}

function attachUser(user, users) {
    let username = "Anonimous";
    if (user) {
        username = user;
    }

    let dateTime = new Date().toLocaleString();
    let elem = document.createElement("p");
    let formattedMsg = "<span style='color: green;'><i>" + dateTime + " <strong>" + username + "</strong> joined</i></span>";

    let $newMsg = $(elem).html(formattedMsg);
    $newMsg.appendTo($chatBoard);

    $usersList.html("");
    for (usr of users) {
        let nick = document.createElement("div");
        $(nick).html(usr).addClass(usr.replace("@", "at").replace(".", "dot")).appendTo($usersList);
    }   
}

function detachUser(user) {
    let username = "Anonimous";
    if (user) {
        username = user;
    }

    let dateTime = new Date().toLocaleString();
    let elem = document.createElement("p");
    let formattedMsg = "<span style='color: red;'><i>" + dateTime + " <strong>" + username + "</strong> quit</i></span>";

    let $newMsg = $(elem).html(formattedMsg);
    $newMsg.appendTo($chatBoard);

    $usersList.find("." + username.replace("@", "at").replace(".", "dot")).first().remove();
}