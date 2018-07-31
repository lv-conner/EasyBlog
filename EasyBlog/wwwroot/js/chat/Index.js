/// <reference path="../../lib/signalr/dist/browser/signalr.js" />

const connection = new signalR.HubConnectionBuilder()
    .withUrl("/Chat")
    .configureLogging(signalR.LogLevel.Information)
    .build();
connection.on("Hello", function (message) {
    console.log(message);
});
connection.on("GetFirendList", function (firendList) {
    console.log(firendList);
});
connection.on("BroadCast", function (msg) {
    console.log("收到广播：" + msg);
});
connection.on("SendSuccessed", function (msg) {

});
connection.on("Connected", function (msg) {
    console.log(msg);
});
connection.start().then(function () {
    connection.invoke("BroadCast", "各位好").then(() => {
        console.log("发送成功");
    });
})