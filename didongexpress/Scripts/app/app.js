(function (w) {
    'use strict';

    var app = {
        isDebug: true,
        log: function () {
            if (this.isDebug) {
                var arr = Array.prototype.slice.apply(arguments);
                console.log(arr);
            }
        }
    };

    window.app = app;
})(window);