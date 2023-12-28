// Client Association
var swiper = new Swiper(".myClient", {
  slidesPerView: 3,
  spaceBetween: 20,
  loop: true,
   autoplay: {
          delay: 2500,
          disableOnInteraction: false,
        },
  pagination: {
    el: ".swiper-pagination",
    clickable: true,
  },
  breakpoints: {
    320: {
      slidesPerView: 1,
      spaceBetween: 10,
    },
    375: {
      slidesPerView: 1,
      spaceBetween: 10,
    },
    425: {
      slidesPerView: 1,
      spaceBetween: 10,
    },
    640: {
      slidesPerView: 2,
      spaceBetween: 10,
    },
    768: {
      slidesPerView: 4,
      spaceBetween: 10,
    },
    1024: {
      slidesPerView: 5,
      spaceBetween: 10,
    },
  },
});
// Promo Banner
var swiper = new Swiper(".myPromoBanner", {
  slidesPerView: 2,
  spaceBetween: 10,
  loop: true,
  breakpoints: {
    320: {
      slidesPerView: 1,
      spaceBetween: 10,
    },
    375: {
      slidesPerView: 1,
      spaceBetween: 10,
    },
    425: {
      slidesPerView: 1,
      spaceBetween: 10,
    },
    640: {
      slidesPerView: 1,
      spaceBetween: 10,
    },
    768: {
      slidesPerView: 1,
      spaceBetween: 10,
    },
    1024: {
      slidesPerView: 2,
      spaceBetween: 10,
    },
  },
  navigation: {
    nextEl: ".swiper-button-next",
    prevEl: ".swiper-button-prev",
  },
});

// dahsboard Promo banner

var swiper = new Swiper(".dashboardPromoBanner", {
  slidesPerView: 1,
  spaceBetween: 10,
  loop: true,
  breakpoints: {
    320: {
      slidesPerView: 1,
      spaceBetween: 10,
    },
    375: {
      slidesPerView: 1,
      spaceBetween: 10,
    },
    425: {
      slidesPerView: 1,
      spaceBetween: 10,
    },
    640: {
      slidesPerView: 1,
      spaceBetween: 10,
    },
    768: {
      slidesPerView: 1,
      spaceBetween: 10,
    },
    1024: {
      slidesPerView: 1,
      spaceBetween: 10,
    },
  },
  navigation: {
    nextEl: ".swiper-button-next",
    prevEl: ".swiper-button-prev",
  },
});

// dahsboard Promo banner

var swiper = new Swiper(".dashboardGiftCard", {
  slidesPerView: 3,
  spaceBetween: 10,
  loop: true,
  breakpoints: {
    320: {
      slidesPerView: 1,
      spaceBetween: 10,
    },
    375: {
      slidesPerView: 1,
      spaceBetween: 10,
    },
    425: {
      slidesPerView: 1,
      spaceBetween: 10,
    },
    640: {
      slidesPerView: 1,
      spaceBetween: 10,
    },
    768: {
      slidesPerView: 1,
      spaceBetween: 10,
    },
    1024: {
      slidesPerView: 3,
      spaceBetween: 10,
    },
  },
  navigation: {
    nextEl: ".swiper-button-next",
    prevEl: ".swiper-button-prev",
  },
});
// Back to top
$(window).on("scroll", function () {
  var scroll = jQuery(window).scrollTop();
  if (scroll > 300) {
    $(".back-to-top").show(1000);
  } else {
    $(".back-to-top").hide(1000);
  }
});

// mobile menu

  $(".show-mobile-nav").click(function () {
    $(".responsive-menu").addClass("show-nav");
  });
  $(".close-mobile-nav").click(function () {
    $(".responsive-menu").removeClass("show-nav");
  });
  
// Mobile product hode show
  $(".less-icon").hide();
  $(".more-icon").click(function(){
    $(".mobile-recharge-inner-icon").addClass("product-hide");
    $(".more-icon").hide();
    $(".less-icon").show();
  });
  $(".less-icon").click(function(){
    $(".mobile-recharge-inner-icon").removeClass("product-hide");
    $(".more-icon").show();
    $(".less-icon").hide();
  });


  // Home Check Plan
  $(".plan-box").hide();
  $(".h-checkplan").click(function(){
    $(".plan-box").show();
  });
  $(".plan-close").click(function(){
    $(".plan-box").hide();
      $(".bnrimg").show();
      //document.getElementById("imgbanner").style.display = "none";
      //document.getElementById("plandiv").style.display = "block";
  });

  // giftcard filter
  $(".filter-btn").click(function(){
    $(".check-filter-box").toggleClass("filter-show");
  });

  // mobile dropdown
  $(".mobile-item-dropdown").click(function(){
    $(".item-dropdown").toggleClass("item-show");
  });
  $(".close-mobile-nav").click(function(){
    $(".item-dropdown").removeClass("item-show");
  });

  // desktop more service

  $(".d-more-serv").click(function(){
    $(".d-more-service").toggle();
  });


  // fixed header
  $(window).scroll(function() {    
    var scroll = $(window).scrollTop();

    if (scroll >= 100) {
        $(".desktop-header").addClass("headerwhite");
    } else {
        $(".desktop-header").removeClass("headerwhite");
    }
});
 