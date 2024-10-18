$(function() {
  $(window).scroll(function() {
    if ($(this).scrollTop() > 1){
    $('header').addClass("sticky");
    }
    else{
    $('header').removeClass("sticky");
    }
    });
});

$(function() {
    const iconMenu = document.querySelector('.burger-box');
    const menuBody = document.querySelector('.sliding-panel-content');
    const panelBody = document.querySelector('.sliding-panel-fade-screen');
  
    if (iconMenu) {
        iconMenu.addEventListener("click", function(e) {
            document.body.classList.toggle('_lock');
            iconMenu.classList.toggle('show');
            menuBody.classList.toggle('show');
            panelBody.classList.toggle('show');
        });
    }
  
    if (panelBody) {
        panelBody.addEventListener("click", function() {
            document.body.classList.remove('_lock');
            iconMenu.classList.remove('show');
            menuBody.classList.remove('show');
            panelBody.classList.remove('show');
        });
    }
  
    const menuLinks = document.querySelectorAll('.menu-list a[data-goto]');
    if (menuLinks.length > 0) {
        menuLinks.forEach(menuLink => {
            menuLink.addEventListener("click", onMenuLinkClick);
        });
        
        function onMenuLinkClick(e) {
            e.preventDefault();
            const menuLink = e.target;
            if (menuLink.dataset.goto && document.querySelector(menuLink.dataset.goto)) {
                const gotoBlock = document.querySelector(menuLink.dataset.goto);
                const gotoBlockValue = gotoBlock.getBoundingClientRect().top + window.pageYOffset - document.querySelector('header').offsetHeight;
  
                if (iconMenu.classList.contains('show')) {
                    document.body.classList.remove('_lock');
                    iconMenu.classList.remove('show');
                    menuBody.classList.remove('show');
                    panelBody.classList.remove('show');
                }
  
                window.scrollTo({
                    top: gotoBlockValue,
                    behavior: "smooth"
                });
            }
        }
    }
});


(function () {
    document.addEventListener("DOMContentLoaded", () => {
        //Sticky header
        let prevScrollpos = window.pageYOffset;

        document.addEventListener('scroll', () => {
            const header = document.querySelector('.page-header');
            if (!header) return;

            if (window.pageYOffset > 80) {
                header.classList.add('sticky');
            } else {
                header.classList.remove('sticky');
            }

            let currentScrollPos = window.pageYOffset;

            if (prevScrollpos > currentScrollPos) {
                header.style.top = '0';
            }

            if (prevScrollpos < currentScrollPos && currentScrollPos > 50) {
                if(window.innerWidth < 768) {
                    header.style.top = '-4rem';
                } else {
                    header.style.top = '-6.5rem';
                }
            }

            prevScrollpos = currentScrollPos <= 0 ? 0 : currentScrollPos;
        });
    });
})();




document.addEventListener('DOMContentLoaded', function() {
    document.addEventListener('wpcf7mailsent', function(event) {
        const formContainer = document.getElementById('form-container');
        const successMessage = document.getElementById('success-message');

        formContainer.style.display = 'none';
        successMessage.style.display = 'block';
    });
});



