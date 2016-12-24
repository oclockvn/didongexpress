

//(function ($, document, window, undefined) {

    

//})(jQuery, document, window, undefined);

function scrollTop() {

    /*
     * use jquery animate is ok,
     * 
     * but if you care about performance, dont use it
     * 
     * use...velocity instead
     */

    /*
    $('html, body').animate({
        scrollTop: '0'
    }, 500);
    */

    // velocity version
    $('html').velocity('scroll', { offset: "0", mobileHA: false });

    // show/hide button after scroll
    // we can use callback
    // but there is a better solution
}

$(document).ready(function () {

    var $document = $(document),
        $scroll_top_button = $('#button-scroll-top');

    $('.bxslider').bxSlider({
        controls: false
    });

    $document.on('click', '#button-scroll-top', scrollTop);

    $('#button-scroll-top').waypoint(function (direction) {
        // show if down
        if (direction === 'down') {
            $scroll_top_button.addClass('show-up');
            app.log('show button', 1, 2, true);
            app.log('hello %s', 'Quang', { name: 'kratos' });
        } else { // hide if up
            $scroll_top_button.removeClass('show-up');
            app.log('hide button');
        }
    }, {
        offset: '200px' // start action if offset top = 200px
    });
    
});