var canvas = document.getElementById('plotCanvas');
//Always check for properties and methods, to make sure your code doesn't break in other browsers.
if (canvas.getContext) {

    var width = canvas.width;
    var height = canvas.height;
    const n = 256;
    var ax = 4 * Math.PI / n;
    var mx = width / (4 * Math.PI);
    var bx = 0;
    var my = -height / 2;
    var by = height / 2;

    var context = canvas.getContext('2d');
    context.beginPath();

    for (i = 0; i < n; i++) {
        var x = i * ax;
        var y = Math.sin(x);
        var dx = x * mx + bx;
        var dy = y * my + by;
        if (i === 0) {
            context.moveTo(dx, dy);
        }
        else {
            context.lineTo(dx, dy);
        }
    }
    // for (i = 0; i < n; i++) {
    //     var x = i * ax;
    //     var dx = x * mx + bx;
    //     context.moveTo(dx, (height/2) - 2);
    //     context.lineTo(dx, (height/2) + 2);
    // }

    // context.moveTo(0, 0);
    // context.lineTo(width-1, height-1);

    context.stroke();
}
