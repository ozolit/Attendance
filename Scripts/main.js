var faq = 0;
function pageLoad() {
    alert("welcome to village")
    pageScroll();
    showFaq();
    swiperTestimonial();
    navBarControl();

}

function pageScroll() {
    window.addEventListener('scroll', () => {
        var navElement = document.querySelector('nav');
        //alert(navElement);
        navElement.classList.toggle('window-scroll', window.scrollY > 100);
    })
}

//show hde faq answer
function showFaq() {
    const faqs = document.querySelectorAll('.faq');
    faqs.forEach(faq => {
        faq.addEventListener('click', () => {
           
            faq.classList.toggle('open');

            //change Icon function
            changeIcon(faq);
            
        })

    })
}

function changeIcon(faq) {
    const icon = faq.querySelector('.faq__icon i');
    if (icon.className === 'uil uil-plus') {
        icon.className = "uil uil-minus";
    } else {
        icon.className = "uil uil-plus";
    }
}

function swiperTestimonial() {
    var swiper = new Swiper(".mySwiper", {
        slidesPerView: 2,
        spaceBetween: 30,
        pagination: {
            el: ".swiper-pagination",
            clickable: true,
        },
    });
}

//show/hide nav mennu


 
const menu = document.querySelector(".nav__menu");
const menuOpenBtn = document.querySelector("#open-menu-btn");
const menuCloseBtn = document.querySelector("#close-menu-btn");

menuOpenBtn.addEventListener('click', () => {
    menu.style.display = "flex";
    menuCloseBtn.style.display = "inline-block";
    menuOpenBtn.style.display = "none";
});

const closeMenu = () => {
    menu.style.display = "none";
    menuCloseBtn.style.display = "none";
    menuOpenBtn.style.display = "inline-block";
}

menuCloseBtn.addEventListener('click', closeMenu);

