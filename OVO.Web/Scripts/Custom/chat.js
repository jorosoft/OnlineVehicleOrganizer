$.connection.hub.start();
const chat = $.connection.chatHub;

chat.client.addMessage = (msg, user) => {
    updateChat(msg, user);
}

$chatBoard = $("#chatBoard");
$msgText = $("#messageText");
msgText = document.getElementById("messageText");
sendBtn = document.getElementById("chatBtn");

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
}