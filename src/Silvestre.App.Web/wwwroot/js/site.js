// Menu toggle + theme handling. The initial theme class is set by the inline script in _Layout (no flash).
document.addEventListener('DOMContentLoaded', function () {
    var burger = document.querySelector('.navbar-burger');
    if (!burger) { return; }

    burger.addEventListener('click', function () {
        var nav = document.getElementById('main-nav');
        var open = nav.classList.toggle('hidden') === false;
        document.getElementById('main-nav-button-open').classList.toggle('hidden', !open);
        document.getElementById('main-nav-button-closed').classList.toggle('hidden', open);
        burger.setAttribute('aria-expanded', open ? 'true' : 'false');
    });

    // Close the menu after picking a link.
    document.querySelectorAll('#main-nav a').forEach(function (a) {
        a.addEventListener('click', function () {
            if (!document.getElementById('main-nav').classList.contains('hidden')) { burger.click(); }
        });
    });
});

Silvestre = function () {
    var root = document.documentElement;
    var media = window.matchMedia('(prefers-color-scheme: dark)');

    function stored() {
        try { return localStorage.getItem('theme'); } catch (e) { return null; }
    }

    // While the visitor has not chosen explicitly, follow the OS setting live.
    media.addEventListener('change', function (e) {
        if (!stored()) { root.classList.toggle('dark', e.matches); }
    });

    return {
        toggleDarkMode: function () {
            var dark = !root.classList.contains('dark');
            root.classList.toggle('dark', dark);
            try { localStorage.setItem('theme', dark ? 'dark' : 'light'); } catch (e) { }
        }
    };
}();
