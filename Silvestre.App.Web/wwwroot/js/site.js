// Navbar Toggle
document.addEventListener('DOMContentLoaded', function () {

    // Get all "navbar-burger" elements
    var $navbarBurgers = Array.prototype.slice.call(document.querySelectorAll('.navbar-burger'), 0);

    // Check if there are any navbar burgers
    if ($navbarBurgers.length > 0) {

        // Add a click event on each of them
        $navbarBurgers.forEach(function ($el) {
            $el.addEventListener('click', function () {

                // Get the "main-nav" element
                var $target = document.getElementById('main-nav');
                var $targetButtonOpen = document.getElementById('main-nav-button-open');
                var $targetButtonClosed = document.getElementById('main-nav-button-closed');

                // Toggle the class on "main-nav"
                $target.classList.toggle('hidden');
                $targetButtonOpen.classList.toggle('hidden');
                $targetButtonClosed.classList.toggle('hidden');
            });
        });
    }

});

Silvestre = function () {
    var darkMode = false;

    // On page load or when changing themes, best to add inline in `head` to avoid FOUC
    if (localStorage.theme === 'dark' || (!('theme' in localStorage) && window.matchMedia('(prefers-color-scheme: dark)').matches)) {
        document.documentElement.classList.add('dark');
        localStorage.theme = 'dark';
        darkMode = true;
    } else {
        document.documentElement.classList.remove('dark');
        localStorage.theme = 'light';
    }

    function setCheckboxValue(className, enabled) {
        var toggles = document.getElementsByClassName(className);
        for (var ix = 0; ix < toggles.length; ix++) {
            toggles[ix].checked = enabled;
        }
    }

    setCheckboxValue("theme-toggle", darkMode);

    return {
        darkMode: darkMode,

        toggleDarkMode: function () {
            this.darkMode = !this.darkMode;

            if (this.darkMode) {
                document.documentElement.classList.add('dark');
                localStorage.theme = 'dark';
            }
            else {
                document.documentElement.classList.remove('dark');
                localStorage.theme = 'light';
            }

            setCheckboxValue("theme-toggle", this.darkMode);
        }
    };
}();