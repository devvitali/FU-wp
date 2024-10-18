$('.full-gallery-slider').slick({
    slidesToShow: 1,
    slidesToScroll: 1,
    arrows: false,
    dots: false,
    fade: true,
    asNavFor: '.mini-gallery-slider',
    responsive: [
        {
          breakpoint: 768,
          settings: {
                autoplay: true,
                autoplaySpeed: 3000,
          }
        }
      ]
});

$('.mini-gallery-slider').slick({
    slidesToShow: 6,
    slidesToScroll: 1,
    asNavFor: '.full-gallery-slider',
    dots: false,
    nextArrow: '<button class="slick-arrow slick-next"><img src="https://fu.devv.top/wp-content/themes/founders-unplugged/img/svg/arrow-next.svg" alt="arrow-next"></button>',
    prevArrow: '<button class="slick-arrow slick-prev"><img src="https://fu.devv.top/wp-content/themes/founders-unplugged/img/svg/arrow-prev.svg" alt="arrow-prev"></button>',
    focusOnSelect: true,
    responsive: [
      {
        breakpoint: 1081,
        settings: {
            slidesToShow: 4,
            slidesToScroll: 1,
        }
      },
      {
        breakpoint: 768,
        settings: {
            slidesToShow: 3,
            slidesToScroll: 1,
        }
      }
    ]
});

$('.reviews-slider').slick({
    slidesToShow: 1,
    slidesToScroll: 1,
    dots: false,
    nextArrow: '<button class="slick-arrow slick-next"><img src="https://fu.devv.top/wp-content/themes/founders-unplugged/img/svg/arrow-next-rev.svg" alt="arrow-next"></button>',
    prevArrow: '<button class="slick-arrow slick-prev"><img src="https://fu.devv.top/wp-content/themes/founders-unplugged/img/svg/arrow-prev-rev.svg" alt="arrow-prev"></button>',
	autoplay: true,
    autoplaySpeed: 10000,
    responsive: [
        {
          breakpoint: 768,
          settings: {
            appendArrows:'.slider-arrows',
          }
        }
    ]
});

Fancybox.bind('[data-fancybox="gallery"]', {
    Hash: false,
    Thumbs: false,
    compact: false,
    
    contentClick: "toggleCover",
    wheel: "slide",

    Toolbar: {
      display: {
        left: [],
        middle: [],
        right: ["close"],
      },
    },

    Images: {
      Panzoom: {
        panMode: "mousemove",
        mouseMoveFactor: 1.1,
        mouseMoveFriction: 0.12
      },
    },
});

function playPauseVideo() {
    let videos = document.querySelectorAll("video");
    videos.forEach((video) => {
        video.muted = true;
        let playPromise = video.play();
        if (playPromise !== undefined) {
            playPromise.then((_) => {
                let observer = new IntersectionObserver(
                    (entries) => {
                        entries.forEach((entry) => {
                            if (
                                entry.intersectionRatio !== 1 &&
                                !video.paused
                            ) {
                                video.pause();
                            } else if (video.paused) {
                                video.play();
                            }
                        });
                    },
                    { threshold: 0.2 }
                );
                observer.observe(video);
            });
        }
    });
}
playPauseVideo();

$(function() {

    const popupLinks = document.querySelectorAll('.popup-link');
    const body = document.querySelector('body');
    const lockPadding = document.querySelectorAll(".lock-padding");
  
    let unlock = true;
  
    const timeout= 800;
  
    if (popupLinks.length > 0) {
      for (let index = 0; index < popupLinks.length; index++) {
        const popupLink = popupLinks[index];
        popupLink.addEventListener("click", function (e) {
          const popupName = popupLink.getAttribute('href').replace('#', '');
          const curentPopup = document.getElementById(popupName);
          popupOpen(curentPopup);
          e.preventDefault();
        });
      }
    }
  
    const popupCloseIcon = document.querySelectorAll('.close-popup');
    if (popupCloseIcon.length > 0) {
      for (let index = 0; index < popupCloseIcon.length; index++) {
        const el = popupCloseIcon[index];
        el.addEventListener('click', function (e) {
          popupClose(el.closest('.popup'));
          e.preventDefault();
        });
      }
    }
  
    function popupOpen(curentPopup) {
      if (curentPopup && unlock) {
        const popupActive = document.querySelector('.popup.open');
        if (popupActive) {
          popupClose(popupActive, false);
        } else {
          bodyLock();
        }
        curentPopup.classList.add('open');
        curentPopup.addEventListener("click", function (e) {
          if (!e.target.closest('.popup-content')) {
            popupClose(e.target.closest('.popup'));
          }
        });
      }
    }
  
    function popupClose(popupActive, doUnlock = true) {
      if (unlock) {
        popupActive.classList.remove('open');
        if (doUnlock) {
          bodyUnLock();
        }
      }
    }
  
    function bodyLock() {
      body.classList.add('lock');
  
      unlock = false;
      setTimeout(function () {
        unlock = true;
      }, timeout);
    }
  
    function bodyUnLock () {
      unlock = false;
      setTimeout(function () {
        unlock = true;
      }, timeout);
    }
  
});

document.addEventListener('DOMContentLoaded', function() {
  function toggleAnchorBlock(e) {
      e.preventDefault();

      var targetId = this.getAttribute('href').substring(1);
      var targetBlock = document.getElementById(targetId);

      if (targetBlock.classList.contains('show-block')) {
          targetBlock.classList.remove('show-block');
      } else {
          var allBlocks = document.querySelectorAll('.anchor-f');
          allBlocks.forEach(function(block) {
              block.classList.remove('show-block');
          });

          targetBlock.classList.add('show-block');
      }
  }

  var links = document.querySelectorAll('.anchor-link');
  links.forEach(function(link) {
      link.addEventListener('click', toggleAnchorBlock);
  });
});

function readMoreFun(param, param_id) {
  let elements = document.getElementsByClassName(param);
  let element_id = document.getElementById(param_id);

  for (let i = 0; i < elements.length; i++) {
      elements[i].classList.toggle("hidden-content");
  }

  element_id.classList.toggle("hidden-readmore");

  const cardItem = element_id.closest('.card-item');

  if (elements[0].classList.contains('hidden-content')) {
      cardItem.scrollIntoView({ behavior: 'smooth' });
  }
}