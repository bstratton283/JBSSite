$(function () {

    //Open navbar's 2nd level dropdown
    $('.dropdown-submenu a.dropdown-submenu-triggerbutton').click(function (e) {
        $(this).next('ul').toggle();
        e.stopPropagation();
        e.preventDefault();
    });

    //Calculate the footer stats
    $("#line-count").html(
        $(".body-content > .prettyprint > ol.linenums > li").length
    );

})