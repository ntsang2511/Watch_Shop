// pre loader

function bodyload() {
    document.getElementById("pre-loader").style.display = "none";
}

// go to top 

var prevScrollpos = window.pageYOffset;
window.onscroll = function() {
    var currentScrollPos = window.pageYOffset;
    if (prevScrollpos > currentScrollPos) {
        document.querySelector(".nav-sec").style.top = "0";
    } else {
        document.querySelector(".nav-sec").style.top = "-100px";
    }
    if (prevScrollpos < currentScrollPos) {
        document.getElementById("myBtn").style.display = "block";
    } else {
        document.getElementById("myBtn").style.display = "none";
    }
    prevScrollpos = currentScrollPos;

};

function topFunction() {
    document.body.scrollTop = 0; // For Safari
    document.documentElement.scrollTop = 0; // For Chrome, Firefox, IE and Opera
}



// For LOgin Form

$(document).ready(function() {
    $("#search").click(function() {
        $(".search").show();
        $(".fa-close").show();
    });
    $(".fa-close").click(function() {
        $(".search").hide();
        $(".fa-close").hide();
    });

    $(".signup-form").hide();
    $(".log").addClass("activee");
    $(".fa-eye-slash").hide();

    $(".sign").click(function() {
        $(".signup-form").show();
        $(".login-form").hide();
        $(".sign").addClass("activee");
        $(".log").removeClass("activee");
    });

    $(".log").click(function() {
        $(".sign").removeClass("activee");
        $(".log").addClass("activee");
        $(".signup-form").hide();
        $(".login-form").show();
    });
    $(".fa-eye").click(function() {
        $(".fa-eye").hide();
        $(".fa-eye-slash").show();
    });
    $(".fa-eye-slash").click(function() {
        $(".fa-eye-slash").hide();
        $(".fa-eye").show();
    });
});

function myFunction() {
    var x = document.getElementById("myInput");
    if (x.type === "password") {
        x.type = "text";
    } else {
        x.type = "password";
    }
}


function myFunction2() {
    var x = document.getElementById("myInput2");
    if (x.type === "password") {
        x.type = "text";
    } else {
        x.type = "password";
    }
}

// product categories

$('.buttons').click(function() {
    var buttonvalue = $(this).attr('data-filter');

    if (buttonvalue == 'all') {
        $('.image-filter').show('1000');
    } else {
        $('.image-filter').not('.' + buttonvalue).hide('200');
        $('.image-filter').filter('.' + buttonvalue).show('200');
    }
    $(this).addClass('active').siblings().removeClass('active');
});