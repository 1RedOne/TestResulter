﻿"use strict";

var connection = new signalR.HubConnectionBuilder().withUrl("/chatHub").build();



function showalert(message, alerttype) {
    var para = document.createElement("div");
    para.innerHTML = '<div id="alertdiv" class="alert ' + alerttype + '"><span>' + message + '</span></div>'
    document.querySelector("#notificationList").appendChild(para);
}


//Disable send button until connection is established
document.getElementById("sendButton").disabled = true;

connection.on("ReceiveMessage", function (user, message) {
    console.log("hi from " + user + " message" + message);
    showalert(message, "alert-primary");
    var msg = message.replace(/&/g, "&amp;").replace(/</g, "&lt;").replace(/>/g, "&gt;");
    var encodedMsg = user + " says " + msg;
    var li = document.createElement("li");
    li.textContent = encodedMsg;
    document.getElementById("messagesList").appendChild(li);
});

connection.start().then(function () {
    document.getElementById("sendButton").disabled = false;
}).catch(function (err) {
    return console.error(err.toString());
});

document.getElementById("sendButton").addEventListener("click", function (event) {
    var user = document.getElementById("userInput").value;
    var message = document.getElementById("messageInput").value;
    connection.invoke("SendMessage", user, message).catch(function (err) {
        return console.error(err.toString());
    });
    event.preventDefault();
});