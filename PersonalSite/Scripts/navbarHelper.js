var navbarHelper = (function () {
    "use strict";

    var module = {
        bindPageEvents: function () {

            //Open navbar's 2nd level dropdown
            $(".dropdown-submenu a.dropdown-submenu-triggerbutton").on("click", function (e) {
                $(this).next("ul").toggle();
                e.stopPropagation();
                e.preventDefault();
            });

        }

    }
    return module;
})();