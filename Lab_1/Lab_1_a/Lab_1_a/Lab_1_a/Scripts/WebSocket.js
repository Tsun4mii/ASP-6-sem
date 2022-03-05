var ta;
var ws = null;
var btnstart;
var btnstop;
window.onload = function () {
        ta = document.getElementById('ta');
        btnstart = document.getElementById('btnstart');
        btnstop = document.getElementById('btnstop');
        btnstart.disabled = false;
        btnstop.disabled = true;
    
}

function start() {
    if (ws == null) {
        ws = new WebSocket("wss://" + location.host + "/websockets.websocket");
        ws.onopen = function () { ws.send('connect'); }
        ws.onclose = function () { console.log('onclose', s); }
        ws.onmessage = function (evt) { ta.innerHTML += '\n' + evt.data; }
        ws.onerror = function (err) { console.log(err) }
        btnstart.disabled = true;
        btnstop.disabled = false;
    }
}


function stop() {
    ws.close();
    ws = null;
    btnstart.disabled = false;
    bstop.disabled = true;
}