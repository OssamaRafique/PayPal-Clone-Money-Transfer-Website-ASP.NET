/* ==============================================
 Website Preloader
 =============================================== */

$(window).on("load",function() {
    'use strict';
    // Animate loader off screen
    $(".se-pre-con").fadeOut( "slow" );

});


/* ==============================================
 Calling Scroll Animations
 =============================================== */
'use strict';
AOS.init();


/* ==============================================
 Navigation Fixed on Scroll
 =============================================== */
$(window).scroll(function(){
    'use strict';
    var scroll = $(window).scrollTop();
    if (scroll >= 2)
    {
        $('nav').addClass('nav-fixed');
    }
    else {
        $('nav').removeClass('nav-fixed');
    }
});


/* ==============================================
 Navigation Click & Active on Reaching Section
 =============================================== */
'use strict';
var sections = $('section')
    , nav = $('nav')
    , nav_height = nav.outerHeight();

$(window).on('scroll', function () {
    'use strict';
    var cur_pos = $(this).scrollTop();

    sections.each(function() {
        var top = $(this).offset().top - nav_height - 90,
            bottom = top + $(this).outerHeight();

        if (cur_pos >= top && cur_pos <= bottom) {
            nav.find('a').removeClass('active');
            sections.removeClass('active');

            $(this).addClass('active');
            nav.find('a[href="#'+$(this).attr('id')+'"]').addClass('active');
        }
    });
});

var navlia = $('.nav li a');
$(navlia).on('click',function() {
    'use strict';
    var hreff = $(this).attr('href');
    $('html, body').animate({
        scrollTop: $(hreff).offset().top-60
    }, 800);
});

$('nav .logoo a').on('click',function() {
    'use strict';
    $(navlia).removeClass('active');
    $('.nav li:first-child a').addClass('active');
});





$(document).ready(function() {

    /* ==============================================
     Testimonial Carousel
     =============================================== */
    $("#testimonial").owlCarousel({
        autoPlay: 4000, //Set AutoPlay to 4 seconds
        items : 3,
        itemsDesktop : [1199,3],
        itemsDesktopSmall : [979,2],
        itemsMobile : [500,1]
    });


    /* =============================================
     Banner Carousel
     ==============================================*/
    $(".owl-carousel2").owlCarousel({
        items: 1,
        autoPlay: 4000, //Set AutoPlay to 4 seconds
        stopOnHover: false,
        loop:true,
        transitionStyle : "fade",
        pagination:false,
        nav:false
    });

    /* ==============================================
     Accordian used in "What we can offer?" Section
     =============================================== */
    'use strict';
    var acordian = $(".acordian");
    $(acordian).on('click',function(){
        'use strict';
        if($(this).hasClass('active')){
            $(this).toggleClass('active')
        }
        else{
            $(acordian).removeClass('active');
            $(this).addClass('active');
        }
    });


    /* ==============================================
     Calling Nice Scroll
     =============================================== */
    'use strict';
    $("html").niceScroll();

});


/* ==============================================
 Scroll Back To Top
 =============================================== */

'use strict';
window.onscroll = function() {scrollFunction()};

function scrollFunction() {
    'use strict';
    if (document.body.scrollTop > 20 || document.documentElement.scrollTop > 20) {
        document.getElementById("myBtn").style.display = "block";
    } else {
        document.getElementById("myBtn").style.display = "none";
    }
}
function topFunction() {
    $('body,html').animate({
        scrollTop: 0
    }, 1500);
}



/* ==============================================
 Why Choose us Video Animation | Youtube Link Video
 =============================================== */

<!-- On Click of Video Play -->
'use strict';
var videmb = $('.video-embed');
var vidthmb = $(videmb).find(".thumb");
var qut = $(".quote-div");
$(videmb).find('iframe')[0].src += "?rel=0";
var clicked = true;
var newWidth=$(window).width();
$(videmb).on('click',function(){
    'use strict';
    if(clicked === true && newWidth >= 992){
        $(videmb).animate({marginTop: '-31px',marginBottom:'111px'});
        $(qut).animate({bottom: '-11',zIndex:'-1'});
        $(videmb).animate({marginTop: '0',marginBottom:'80px'});
        $(qut).animate({bottom: '20'});
        $(vidthmb).animate({opacity:'0',zIndex:'-1'});
        $(videmb).find('iframe')[0].src += "&autoplay=1";
        clicked = false;

    }
    else if(clicked === true && newWidth <= 991){
        $(qut).animate({zIndex:'-1'});
        $(vidthmb).animate({opacity:'0',zIndex:'-1'});
        $(videmb).find('iframe')[0].src += "&autoplay=1";
        clicked = false;
    }

});

<!-- On Click Outside Pause -->
$(document).on('click',function(e){
    'use strict';
    if ($(e.target).is('.video-embed,.video-embed *')) {
    }
    else if(clicked === false && newWidth >= 992){
        $(videmb).animate({marginTop: '-31px',marginBottom:'111px'});
        $(qut).animate({bottom: '-11',zIndex:'0'});
        $(videmb).animate({marginTop: '0',marginBottom:'80px'});
        $(qut).animate({bottom: '20'});
        $(vidthmb).animate({opacity:'1',zIndex:'0'});
        var plSRC = $(this).find('iframe').attr('src');
        var pauSRC = plSRC.replace('&autoplay=1','');
        $(videmb).find('iframe').attr('src',pauSRC);
        clicked = true;
    }
    else if(clicked === false && newWidth <= 991){
        $(qut).animate({zIndex:'0'});
        $(vidthmb).animate({opacity:'1',zIndex:'0'});
        var plaSRC = $(this).find('iframe').attr('src');
        var pausSRC = plaSRC.replace('&autoplay=1','');
        $(videmb).find('iframe').attr('src',pausSRC);
        clicked = true;
    }
});

