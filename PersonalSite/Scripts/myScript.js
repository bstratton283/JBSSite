$(function () {

    //Open navbar's 2nd level dropdown
    $('.dropdown-submenu a.dropdown-submenu-triggerbutton').click(function (e) {
        $(this).next('ul').toggle();
        e.stopPropagation();
        e.preventDefault();
    });

})